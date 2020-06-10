using ServiExpress.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiExpress.app_GUI.UsuarioEmpleado
{
    public partial class Ventas : Form
    {
        ControladorEmpleado controladorEmpleado;
        string filtro = null;
        string valorFiltro = null;

        public Ventas(ControladorEmpleado controladorEmpleado)
        {
            this.controladorEmpleado = controladorEmpleado;
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (CmbFiltro.SelectedItem == null)
            {
                MessageBox.Show("No se ha seleccionado el tipo de filtro");
            }
            else if (TxtFiltro.Text == "")
            {
                MessageBox.Show("No se ha dado ningún valor para filtrar");
            }
            else
            {
                controladorEmpleado.SetDataGridViewVentas(DgvVentas, CmbFiltro.SelectedItem.ToString(), TxtFiltro.Text.Trim());
                this.filtro = CmbFiltro.SelectedItem.ToString();
                this.valorFiltro = TxtFiltro.Text.Trim();
            }
        }

        private void DgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells[0].ColumnIndex.Equals(e.ColumnIndex))
            {
                if ((DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells[0].Value.Equals("Pagar"))) 
                {
                    MessageBox.Show("Pagar");
                }
            }
            else if(DgvVentas.Rows[DgvVentas.CurrentRow.Index].Cells[7].ColumnIndex.Equals(e.ColumnIndex)) 
            {
                MessageBox.Show("Documento");
            }
        }
    }
}
