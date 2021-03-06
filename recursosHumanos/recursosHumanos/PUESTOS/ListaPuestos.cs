﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace recursosHumanos.PUESTOS
{
    public partial class listaPuestos : Form
    {
        public listaPuestos(string bd)
        {
            InitializeComponent();

            this.bd = bd;
        }


        //Variables Publicas
        string bd;


        private void listaPuestos_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT PUESTO_ID, TIPO_PUESTO, SUELDO_BASE FROM PUESTO", bd);
            //OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_platillo,nombre_platillo,precio_platillo FROM MENU", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_puestos.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["PUESTO_ID"].ToString());
                elemntos.SubItems.Add(filas["TIPO_PUESTO"].ToString());
                elemntos.SubItems.Add(filas["SUELDO_BASE"].ToString());

                listView_puestos.Items.Add(elemntos);

            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            AgregarPuesto form = new AgregarPuesto(bd, -1);
            form.Show();

            this.Close();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_puestos.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);

                this.Hide();
                AgregarPuesto form = new AgregarPuesto(bd, id);
                form.Show();

                this.Close();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_puestos.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);


                DialogResult resultado = MessageBox.Show("Esta seguro de borrar el puesto?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conexion = new SqlConnection(bd);

                        conexion.Open();
                        string insertar = "DELETE FROM PUESTO WHERE PUESTO_ID = " + id;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView_puestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
