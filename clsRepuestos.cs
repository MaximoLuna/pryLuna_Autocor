using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLuna_Autocor
{
    internal class clsRepuestos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public string Origen { get; set; }

        public void cargarRepuestos(ComboBox cmbMarca, RadioButton optNacional, RadioButton optImportado, RadioButton optAmbos, DataGridView dgvRepuestos)
        {
            using (StreamReader reader = new StreamReader("REPUESTOS.txt"))
            {
                dgvRepuestos.Rows.Clear();
                string auxiliar;
                while (reader.EndOfStream == false)
                {
                    auxiliar = reader.ReadLine();

                    Codigo = int.Parse(auxiliar.Split(',')[0]);
                    Nombre = auxiliar.Split(',')[1];
                    Marca = auxiliar.Split(',')[2];
                    Precio = int.Parse(auxiliar.Split(',')[3]);
                    Origen = auxiliar.Split(',')[4];

                    if (Marca == cmbMarca.Text)
                    {
                        if (optNacional.Checked && Origen == "Nacional")
                        {
                            dgvRepuestos.Rows.Add(Codigo, Nombre, Marca, Precio, Origen);
                        }
                        else
                        {
                            if (optImportado.Checked && Origen == "Importado")
                            {
                                dgvRepuestos.Rows.Add(Codigo, Nombre, Marca, Precio, Origen);
                            }
                            else
                            {
                                if (optAmbos.Checked)
                                {
                                    dgvRepuestos.Rows.Add(Codigo, Nombre, Marca, Precio, Origen);
                                }
                            }
                        }
                    }
                }
            }
        }

        public void grabarRepuesto(TextBox txtCodigo, TextBox txtNombre, ComboBox cmbMarca, TextBox txtPrecio, RadioButton optOrigen)
        {
            using (StreamReader reader = new StreamReader("REPUESTOS.txt"))
            {
                string auxiliar;
                while (reader.EndOfStream == false)
                {
                    auxiliar = reader.ReadLine();
                    if (txtCodigo.Text == auxiliar.Split(',')[0])
                    {
                        MessageBox.Show("Ya existe un repuesto con ese código", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }

            if (txtCodigo.Text != "" && txtNombre.Text != "" && cmbMarca.Text != "" && txtPrecio.Text != "")
            {
                Codigo = int.Parse(txtCodigo.Text);
                Nombre = txtNombre.Text;
                Marca = cmbMarca.Text;
                Precio = int.Parse(txtPrecio.Text);
                if (optOrigen.Checked)
                {
                    Origen = "Nacional";
                }
                else
                {
                    Origen = "Importado";
                }

                using (StreamWriter writer = new StreamWriter("REPUESTOS.txt", true))
                {
                    writer.WriteLine(Codigo + "," + Nombre + "," + Marca + "," + Precio + "," + Origen);
                }

                txtCodigo.Text = "";
                txtNombre.Text = "";
                cmbMarca.SelectedIndex = -1;
                txtPrecio.Text = "";
                optOrigen.Checked = true;
            }
            else
            {
                MessageBox.Show("Hay campos sin completar", "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

