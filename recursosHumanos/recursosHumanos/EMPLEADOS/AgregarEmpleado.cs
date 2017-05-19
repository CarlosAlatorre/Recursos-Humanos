using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace recursosHumanos.EMPLEADOS
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado(string bd, int idParaModificar)
        {
            InitializeComponent();

            this.bd = bd;
            this.idParaModificar = idParaModificar;
        }

        //Variables Publicas
        string bd;
        int idParaModificar, idPuestoMaximo, idPuesto;

        private void label1_Click(object sender, EventArgs e)
        {
           

           

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.TextLength == 0 || txt_domicilio.TextLength == 0 || txt_rfc.TextLength == 0 || txt_telefono.TextLength == 0)
                {
                    MessageBox.Show("Tienes Campos vacios para continuar", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txt_nombre.TextLength >= 15)
                    {
                        MessageBox.Show("No pudes poner un nombre muy largo trata de reducirlo o abreviarlo un poco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nombre.Clear();
                        txt_nombre.Focus();
                    }
                    else
                    {
                        try
                        {
                            if (idParaModificar != -1)
                            {
                                MODIFICAR_EMPLEADO(idParaModificar);
                            }
                            else
                            {
                                AGREGAR_EMPLEADO();
                            }
                        }

                        catch (DBConcurrencyException ex)
                        {
                            MessageBox.Show("Error de concurrencia:\n" + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Empleados form = new Empleados(bd);
                        form.Show();

                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MODIFICAR_EMPLEADO( int id )
        {
            SqlConnection conexion = new SqlConnection(bd);
            conexion.Open();

            string sql2 = "SELECT PUESTO_ID FROM PUESTO WHERE TIPO_PUESTO=" + "'" + combo_puesto.Text + "'";
            SqlCommand cmd212 = new SqlCommand(sql2, conexion);

            int idPuesto = Convert.ToInt32(cmd212.ExecuteScalar());


            string insertar = "UPDATE EMPLEADO SET PUESTO_ID = @PUESTO_ID, NOMBRE = @NOMBRE, RFC = @RFC, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO WHERE EMPLEADO_ID=" + id;
            SqlCommand cmd = new SqlCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@PUESTO_ID", idPuesto);
            cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@RFC", txt_rfc.Text);
            cmd.Parameters.AddWithValue("@DIRECCION", txt_domicilio.Text);
            cmd.Parameters.AddWithValue("@TELEFONO", decimal.Parse(txt_telefono.Text));
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos modificados correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            //Si es -1 significa que no va a modificar
            if (idParaModificar != -1)
            {
                OBTENER_EMPLEADO(idParaModificar);
                btn_agregar.Text = "Modificar";
            }

            DataSet dss = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT TIPO_PUESTO FROM PUESTO", bd);
            //se indica el nombre de la tabla
            da.Fill(dss, "TIPO_PUESTO");
            combo_puesto.DataSource = dss.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            combo_puesto.ValueMember = "TIPO_PUESTO";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Empleados form = new Empleados(bd);
            form.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AGREGAR_EMPLEADO()
        {
            SqlConnection conexion = new SqlConnection(bd);

            conexion.Open();

            string sql2 = "SELECT PUESTO_ID FROM PUESTO WHERE TIPO_PUESTO=" + "'" + combo_puesto.Text + "'";
            SqlCommand cmd212 = new SqlCommand(sql2, conexion);

            int idPuesto = Convert.ToInt32(cmd212.ExecuteScalar());

            //Obtener el id mas alto de los puestos
           // string sql = "SELECT MAX(EMPLEADO_ID) FROM EMPLEADO";
           // SqlCommand cmd21 = new SqlCommand(sql, conexion);

           // idPuestoMaximo = Convert.ToInt32(cmd21.ExecuteScalar()) + 1;


            string insertar = "INSERT INTO EMPLEADO(SEXO, EMAIL, ESTADOCIVIL, NSS, PUESTO_ID, NOMBRE, RFC, DIRECCION, TELEFONO) VALUES (@SEXO, @EMAIL, @ESTADOCIVIL, @NSS,  @PUESTO_ID, @NOMBRE, @RFC, @DIRECCION, @TELEFONO)";
            SqlCommand cmd = new SqlCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@SEXO", textBox_sexo);
            cmd.Parameters.AddWithValue("@EMAIL", textBox_email);
            cmd.Parameters.AddWithValue("@ESTADOCIVIL", textBox_civil);
            cmd.Parameters.AddWithValue("@NSS", textBox_nss);
            cmd.Parameters.AddWithValue("@PUESTO_ID", idPuesto);
            cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@RFC", txt_rfc.Text);
            cmd.Parameters.AddWithValue("@DIRECCION", txt_domicilio.Text);
            cmd.Parameters.AddWithValue("@TELEFONO", txt_telefono.Text);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void OBTENER_EMPLEADO( int id)
        {
            SqlConnection conexion = new SqlConnection(bd);

            conexion.Open();

            string select = "SELECT PUESTO_ID, NOMBRE, RFC, DIRECCION, TELEFONO FROM EMPLEADO WHERE EMPLEADO_ID=" + id;
            SqlCommand cmd = new SqlCommand(select, conexion);
            try
            {
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        idPuesto = reader.GetInt32(0);
                        txt_nombre.Text = reader.GetString(1);
                        txt_rfc.Text = reader.GetString(2);
                        txt_domicilio.Text = reader.GetString(3);
                        txt_telefono.Text = reader.GetString(4);

                    }
                }
                else
                {
                    MessageBox.Show("No se pudo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();

                string sql2 = "SELECT TIPO_PUESTO FROM PUESTO WHERE PUESTO_ID=" + idPuesto;
                SqlCommand cmd212 = new SqlCommand(sql2, conexion);

                combo_puesto.Text = cmd212.ExecuteScalar().ToString();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }
    }
}
