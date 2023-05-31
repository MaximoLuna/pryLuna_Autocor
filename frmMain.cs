using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLuna_Autocor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsRepuestos objRepuesto = new clsRepuestos();
            objRepuesto.grabarRepuesto(txtCodigo, txtNombre, cmbMarca, txtPrecio, optNacional);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultas frmConsultas = new frmConsultas();
            frmConsultas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
