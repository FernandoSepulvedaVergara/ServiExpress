using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.Informes
{
    public partial class Form1 : Form
    {
        List<string> datos = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
            DataSet1 dtsE = new DataSet1();


            #region "CREA TABLA DE EJEMPLO"

            DataTable tabla = new DataTable();
            DataColumn col = new DataColumn("d1");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("d2");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("d3");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("d4");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);
            col = new DataColumn("d5");
            col.DataType = System.Type.GetType("System.String");
            tabla.Columns.Add(col);

            #endregion


            for (int i = 0; i < 10; i++)
            {
                DataRow linea = tabla.NewRow();
                linea["d1"] = "Linea " + (i + 1).ToString();
                linea["d2"] = "Linea " + (i + 1).ToString();
                linea["d3"] = "Linea " + (i + 1).ToString();
                linea["d4"] = "Linea " + (i + 1).ToString();
                linea["d5"] = "Linea " + (i + 1).ToString();

                tabla.Rows.Add(linea);
            }

            dtsE.Tables.RemoveAt(0);    //Eliminamos la tabla que crea por defecto
            dtsE.Tables.Add(tabla);     //Añadimos la tabla que acabamos de crear

            DataTable1BindingSource.DataSource = dtsE;
            DataTable1BindingSource.DataMember = "Table1";
            reportViewer1.RefreshReport();
        }
    }
}
