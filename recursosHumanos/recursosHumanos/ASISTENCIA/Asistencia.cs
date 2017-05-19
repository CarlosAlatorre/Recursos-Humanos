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
using recursosHumanos.PRINCIPAL;

namespace recursosHumanos.ASISTENCIA
{
    public partial class Asistencia : Form
    {
        public Asistencia(string bd)
        {
            InitializeComponent();

            this.bd = bd;
        }

        //Variables Publicas
        string bd;
        int idAsistenciaMaxima;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            DataSet dss = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT NOMBRE FROM EMPLEADO", bd);
            //se indica el nombre de la tabla
            da.Fill(dss, "NOMBRE");
            combo_empleado.DataSource = dss.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            combo_empleado.ValueMember = "NOMBRE";

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(bd);

            conexion.Open();

            //OBTENER LA FECHA ACTUAL
            //  string var1 = dateFecha.Text;
            //  var1 = var1.Substring(0, 4);

            //  string var2 = dateFecha.Text;
            //  var2 = var2.Substring(4, 2);

            //  string var3 = dateFecha.Text;
            //  var3 = var3.Substring(6, 2);    

            //   string FECHAA = string.Concat(var3, var2, var1);
            //fechaa = Convert.ToInt32(FECHAA);

            //Obtener el id mas alto de los puestos
            /*string sql = "SELECT MAX(ASISTENCIA_ID) FROM ASISTENCIA";
            SqlCommand cmd21 = new SqlCommand(sql, conexion);

            idAsistenciaMaxima = Convert.ToInt32(cmd21.ExecuteScalar()) + 1;*/

            //Obtener el ID del empleado
            string sql2 = "SELECT EMPLEADO_ID FROM EMPLEADO WHERE NOMBRE=" + "'" + combo_empleado.Text + "'";
            SqlCommand cmd212 = new SqlCommand(sql2, conexion);

            int idEmpleado = Convert.ToInt32(cmd212.ExecuteScalar());


            string insertar = "INSERT INTO ASISTENCIA(EMPLEADO_ID, FECHA, HORA_ENTRADA) VALUES (@EMPLEADO_ID, @FECHA, @HORA_ENTRADA)";
            SqlCommand cmd = new SqlCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@EMPLEADO_ID", idEmpleado);
            cmd.Parameters.AddWithValue("@FECHA", dateFecha.Text);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", dateHora.Text);

            cmd.ExecuteNonQuery();
            conexion.Close();

            Principal form = new Principal(bd);
            form.Show();

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Principal form = new Principal(bd);
            form.Show();

            this.Close();
        }


    }
}
