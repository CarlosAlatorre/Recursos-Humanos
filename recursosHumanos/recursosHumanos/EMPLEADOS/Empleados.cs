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
    public partial class Empleados : Form
    {
        public Empleados( string bd )
        {
            InitializeComponent();

            this.bd = bd;
        }

        //Variables Publicas
        string bd;

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEmpleado form = new AgregarEmpleado(bd, -1);
            form.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT EMPLEADO_ID,NOMBRE ,  PUESTO_ID, RFC, DIRECCION, TELEFONO FROM EMPLEADO", bd);
            //OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_platillo,nombre_platillo,precio_platillo FROM MENU", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_empleados.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["EMPLEADO_ID"].ToString());
                elemntos.SubItems.Add(filas["NOMBRE"].ToString());
                elemntos.SubItems.Add(filas["PUESTO_ID"].ToString());
                elemntos.SubItems.Add(filas["RFC"].ToString());
                elemntos.SubItems.Add(filas["DIRECCION"].ToString());
                elemntos.SubItems.Add(filas["TELEFONO"].ToString());
               
                listView_empleados.Items.Add(elemntos);

            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_empleados.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);

                this.Hide();
                AgregarEmpleado form = new AgregarEmpleado(bd, id);
                form.Show();

                this.Close();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_empleados.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);


                DialogResult resultado = MessageBox.Show("Esta seguro de borrar el empleado?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexion = new SqlConnection(bd);

                        conexion.Open();
                        string insertar = "DELETE FROM EMPLEADO WHERE EMPLEADO_ID = " + id;
                        SqlCommand cmd = new SqlCommand(insertar, conexion);

                        cmd.ExecuteNonQuery();
                        conexion.Close();

                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("Error de concurrencia:\n" + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lista.Remove();
                }
                else if (resultado == DialogResult.No)
                {

                }
            }
        }
    }
}
