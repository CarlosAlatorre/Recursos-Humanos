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
    public partial class AsistenciaSalida : Form
    {
        public AsistenciaSalida(string bd)
        {
            InitializeComponent();

            this.bd = bd;
        }

        //Variables Publicas
        string bd;

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(bd);
            conexion.Open();

            string sql2 = "SELECT EMPLEADO_ID FROM EMPLEADO WHERE NOMBRE=" + "'" + combo_empleado.Text + "'";
            SqlCommand cmd212 = new SqlCommand(sql2, conexion);

            int idEmpleado = Convert.ToInt32(cmd212.ExecuteScalar());


            string insertar = "UPDATE ASISTENCIA SET HORA_SALIDA = @HORA_SALIDA WHERE EMPLEADO_ID=" + idEmpleado + "AND FECHA=" + "'" + dateFecha.Text + "'";
            SqlCommand cmd = new SqlCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", dateHora.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos modificados correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();

            Principal form = new Principal(bd);
            form.Show();

            this.Close();
        }

        private void AsistenciaSalida_Load(object sender, EventArgs e)
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Principal form = new Principal(bd);
            form.Show();

            this.Close();
        }
    }
}
