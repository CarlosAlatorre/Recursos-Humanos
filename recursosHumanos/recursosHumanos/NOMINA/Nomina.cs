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
    public partial class Nomina : Form
    {
        public Nomina(string bd)
        {
            InitializeComponent();

            this.bd = bd;
        }

        //Variables Publicas
        string bd;
        string fecha1, fecha2, dias1, dias2;
        int asistencias, sueldoBase;
        double sueldoTotal;

        private void Nomina_Load(object sender, EventArgs e)
        {

        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            int i = 3;
            int j = 1;

            foreach (ListViewItem comp in listView_nomina.Items)
            {
                ws.Cells[2, 1] = ("ID");
                ws.Cells[2, 2] = ("NOMBRE");
                ws.Cells[2, 3] = ("ASISTENCIAS");
                ws.Cells[2, 4] = ("SUELDOBASE");
                ws.Cells[2, 5] = ("BONO");
                ws.Cells[2, 6] = ("SUELDOTOTAL");

                ws.Cells[i, j] = comp.Text.ToString();
                //MessageBox.Show(comp.Text.ToString());
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListViewItem foundItem = listView_nomina.FindItemWithText(txt_buscar.Text, false, 0, true);
            if (foundItem != null)
            {
                listView_nomina.TopItem = foundItem;

            }
        }
    

        private void btn_generar_Click(object sender, EventArgs e)
        {


            //OBTENER LAS QUINCENAS
            if (radio_quincena1.Checked)
            {
                dias1 = "01";
                dias2 = "15";

                fecha1 = date_fecha.Text + "-" + dias1;
                fecha2 = date_fecha.Text + "-" + dias2;
            }
            else if (radio_quincena2.Checked)
            {
                dias1 = "16";

                //
                string mes = date_fecha.Text;
                mes = mes.Substring(5, 2);

                string año = date_fecha.Text;
                año = año.Substring(0, 4);

                //

                if (mes == "04" || mes == "06" || mes == "09" || mes == "11")
                {
                    dias2 = "30";
                }
                else if (mes == "02")
                {
                    if (año == "2020" || año == "2024" || año == "2028" || año == "2032" || año == "2036" || año == "2040" || año == "2044" || año == "2048" || año == "2052")
                    {
                        dias2 = "29";
                    }
                    else
                    {
                        dias2 = "28";
                    }
                }
                else
                {
                    dias2 = "31";
                }

                //MessageBox.Show(dias2.ToString(), "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fecha1 = date_fecha.Text + "-" + dias1;
                fecha2 = date_fecha.Text + "-" + dias2;
            }


            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT NOMBRE,  PUESTO_ID, EMPLEADO_ID FROM EMPLEADO", bd);
            //OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_platillo,nombre_platillo,precio_platillo FROM MENU", ds);


            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_nomina.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];

                //OBTENER EL SUELDO BASE POR EL ID DEL PUESTO
                SqlConnection conexion = new SqlConnection(bd);
                conexion.Open();


                //Obtener gastos


               // Obtener SUMA de gastos
                 string sql = "SELECT COUNT(GASTO_ID) FROM GASTOS";
                 SqlCommand cmd21 = new SqlCommand(sql, conexion);

                 var sumaGastos = Convert.ToInt32(cmd21.ExecuteScalar());


                string sql3 = "SELECT SUELDO_BASE FROM PUESTO WHERE PUESTO_ID=" + filas["PUESTO_ID"];
                SqlCommand cmd3 = new SqlCommand(sql3, conexion);

                sueldoBase = Convert.ToInt32(cmd3.ExecuteScalar());

                //CONTAR LAS ASISTENCIAS DEL EMPLEADO

                string sql2 = "SELECT count( EMPLEADO_ID ) FROM ASISTENCIA WHERE EMPLEADO_ID = " + filas["EMPLEADO_ID"] + " AND FECHA>= '" + fecha1 + "' AND FECHA <= '" + fecha2 + "'";
                SqlCommand cmd212 = new SqlCommand(sql2, conexion);

                asistencias = Convert.ToInt32((cmd212.ExecuteScalar()).ToString());


                sueldoTotal = asistencias * sueldoBase;


                //Reducir sueldototal con impuestos
                for(int ii = 0; ii < sumaGastos ; ii++)
                {
                
                    string sal33 = "SELECT IMPUESTO FROM GASTOS WHERE GASTO_ID=" + ii;
                    SqlCommand coman22d = new SqlCommand(sal33, conexion);

                    double gasto = Convert.ToDouble((coman22d.ExecuteScalar()).ToString());

                    gasto = (gasto / 100);
                    sueldoTotal = sueldoTotal - (sueldoTotal * gasto);

                }


                //Select id de la nomina

                string sal3 = "SELECT MAX( NOMINA_ID ) FROM NOMINA ";
                SqlCommand comand = new SqlCommand(sal3, conexion);

            //   int maxNominaId = Convert.ToInt32((comand.ExecuteScalar()).ToString()) + 1;

                string insertar = "INSERT INTO NOMINA(EMPLEADO_ID, SUELDO_TOTAL, BONO) VALUES (@EMPLEADO_ID, @SUELDO_TOTAL, @BONO)";
                SqlCommand cmd = new SqlCommand(insertar, conexion);
              
                cmd.Parameters.AddWithValue("@EMPLEADO_ID", filas["EMPLEADO_ID"]);
                cmd.Parameters.AddWithValue("@SUELDO_TOTAL", sueldoTotal);
                cmd.Parameters.AddWithValue("@BONO", 0);

                cmd.ExecuteNonQuery();


                ListViewItem elemntos = new ListViewItem(filas["EMPLEADO_ID"].ToString());
                elemntos.SubItems.Add(filas["NOMBRE"].ToString());
                elemntos.SubItems.Add((asistencias).ToString());
                elemntos.SubItems.Add((sueldoBase).ToString());
                elemntos.SubItems.Add("No");
                elemntos.SubItems.Add((sueldoTotal).ToString());

                listView_nomina.Items.Add(elemntos);

            }
        }
    }
}
