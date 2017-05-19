using recursosHumanos.ASISTENCIA;
using recursosHumanos.EMPLEADOS;
using recursosHumanos.PUESTOS;
using recursosHumanos.NOMINA;
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

namespace recursosHumanos.PRINCIPAL
{
    public partial class Principal : Form
    {
        public Principal(string bd)
        {
            InitializeComponent();
            this.bd = bd;
        }

        string bd;

        private void Principal_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT ASISTENCIA_ID, EMPLEADO_ID ,  FECHA, HORA_ENTRADA, HORA_SALIDA FROM ASISTENCIA WHERE FECHA='" + date_año.Text + "-" + date_mes.Text + "-" + (date_dia.Text).ToString() + "'"  , bd);
            //OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_platillo,nombre_platillo,precio_platillo FROM MENU", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_nomina.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];

                SqlConnection conexion = new SqlConnection(bd);
                conexion.Open();

                string sql3 = "SELECT NOMBRE FROM EMPLEADO WHERE EMPLEADO_ID=" + filas["EMPLEADO_ID"];
                SqlCommand cmd3 = new SqlCommand(sql3, conexion);

                string nombre = (cmd3.ExecuteScalar().ToString());

                ListViewItem elemntos = new ListViewItem(filas["ASISTENCIA_ID"].ToString());
                elemntos.SubItems.Add(nombre);
                elemntos.SubItems.Add(filas["HORA_ENTRADA"].ToString());
                elemntos.SubItems.Add(filas["HORA_SALIDA"].ToString());
                elemntos.SubItems.Add(filas["FECHA"].ToString());


                listView_nomina.Items.Add(elemntos);

            }

            label_asistencia.Text = "Asistencia del día " + (date_dia.Text).ToString() + " de " + date_mes.Text + " del " + date_año.Text;
        
        }

        private void listaDePuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void listaDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia form = new Asistencia(bd);
            form.Show();

            this.Hide();

        }

        private void horaSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsistenciaSalida form = new AsistenciaSalida(bd);
            form.Show();

            this.Hide();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomina form = new Nomina(bd);
            form.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaPuestos form = new listaPuestos(bd);
            form.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados form = new Empleados(bd);
            form.Show();
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GASTOS form = new GASTOS(bd);
            form.Show();
        }
    }
}
