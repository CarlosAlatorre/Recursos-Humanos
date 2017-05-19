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
    public partial class GASTOS : Form
    {
        public GASTOS(string bd)
        {
            InitializeComponent();
            this.bd = bd;
        }


        //Variables Publicas
        string bd;

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AGREGAR_GASTO form = new AGREGAR_GASTO(bd, -1);
            form.Show();

            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_puestos.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);

                this.Hide();
                AGREGAR_GASTO form = new AGREGAR_GASTO(bd, id);
                form.Show();

                this.Close();
            }
        }

        private void GASTOS_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT GASTO_ID, NOMBRE, IMPUESTO FROM GASTOS", bd);
            //OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_platillo,nombre_platillo,precio_platillo FROM MENU", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_puestos.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["GASTO_ID"].ToString());
                elemntos.SubItems.Add(filas["NOMBRE"].ToString());
                elemntos.SubItems.Add(filas["IMPUESTO"].ToString());

                listView_puestos.Items.Add(elemntos);

            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_puestos.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);


                DialogResult resultado = MessageBox.Show("Esta seguro de borrar el gasto?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexion = new SqlConnection(bd);

                        conexion.Open();
                        string insertar = "DELETE FROM GASTOS WHERE GASTO_ID = " + id;
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
