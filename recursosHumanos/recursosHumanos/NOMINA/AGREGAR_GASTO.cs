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

namespace recursosHumanos.NOMINA
{
    public partial class AGREGAR_GASTO : Form
    {
        public AGREGAR_GASTO(string bd, int idParaModificar)
        {
            InitializeComponent();
            this.bd = bd;
            this.idParaModificar = idParaModificar;
        }
        string bd;
        int idPuestoMaximo, idParaModificar;

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Que el id tenga un -1 significa que no se abrió el form para modificar

            try
            {
                if (txt_nombre.TextLength == 0 || txt_sueldo.TextLength == 0)
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
                                MODIFICAR_PUESTO(idParaModificar);
                            }
                            else
                            {
                                INSERT_PUESTO();
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

                        GASTOS form = new GASTOS(bd);
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

        private void INSERT_PUESTO()
        {
            SqlConnection conexion = new SqlConnection(bd);

            conexion.Open();

            //Obtener el id mas alto de los puestos
            // string sql = "SELECT MAX(PUESTO_ID) FROM PUESTO";
            //  SqlCommand cmd21 = new SqlCommand(sql, conexion);                              


            // idPuestoMaximo = Convert.ToInt32(cmd21.ExecuteScalar()) + 1;


            string insertar = "INSERT INTO GASTOS( NOMBRE, IMPUESTO) VALUES ( @NOMBRE, @IMPUESTO)";
            SqlCommand cmd = new SqlCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@IMPUESTO", txt_sueldo.Text);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        private void OBTENER_PUESTO(int id)
        {

            SqlConnection conexion = new SqlConnection(bd);

            conexion.Open();

            string select = "SELECT NOMBRE, IMPUESTO FROM GASTOS WHERE GASTO_ID=" + id;
            SqlCommand cmd = new SqlCommand(select, conexion);
            try
            {


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        txt_nombre.Text = reader.GetString(0);
                        txt_sueldo.Text = reader.GetDouble(1).ToString();

                    }
                }
                else
                {
                    MessageBox.Show("No se pudo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();

        }

        private void MODIFICAR_PUESTO(int id)
        {

            SqlConnection conexion = new SqlConnection(bd);
            conexion.Open();

            string insertar = "UPDATE GASTOS SET NOMBRE= @NOMBRE, IMPUESTO = @IMPUESTO WHERE GASTO_ID=" + id;
            SqlCommand cmd = new SqlCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@NOMBRE", txt_nombre.Text);
            cmd.Parameters.AddWithValue("@IMPUESTO", decimal.Parse(txt_sueldo.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos modificados correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            GASTOS form = new GASTOS(bd);
            form.Show();

            this.Close();
        }

        private void AGREGAR_GASTO_Load(object sender, EventArgs e)
        {
            //Que el id tenga un -1 significa que no se abrió el form para modificar
            if (idParaModificar != -1)
            {
                OBTENER_PUESTO(idParaModificar);
                btn_agregar.Text = "Modificar";
            }
        }
    }
}
