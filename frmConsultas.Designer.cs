namespace pryLuna_Autocor
{
    partial class frmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.optAmbos = new System.Windows.Forms.RadioButton();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.mrcOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.AllowUserToDeleteRows = false;
            this.dgvRepuestos.AllowUserToOrderColumns = true;
            this.dgvRepuestos.AllowUserToResizeColumns = false;
            this.dgvRepuestos.AllowUserToResizeRows = false;
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Marca,
            this.Origen,
            this.Precio});
            this.dgvRepuestos.Location = new System.Drawing.Point(15, 106);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.ReadOnly = true;
            this.dgvRepuestos.RowHeadersVisible = false;
            this.dgvRepuestos.Size = new System.Drawing.Size(503, 252);
            this.dgvRepuestos.TabIndex = 14;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(437, 56);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 44);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(437, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(81, 44);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optAmbos);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Location = new System.Drawing.Point(15, 36);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(237, 61);
            this.mrcOrigen.TabIndex = 10;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // optAmbos
            // 
            this.optAmbos.AutoSize = true;
            this.optAmbos.Location = new System.Drawing.Point(167, 28);
            this.optAmbos.Name = "optAmbos";
            this.optAmbos.Size = new System.Drawing.Size(57, 17);
            this.optAmbos.TabIndex = 6;
            this.optAmbos.Text = "Ambos";
            this.optAmbos.UseVisualStyleBackColor = true;
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Checked = true;
            this.optNacional.Location = new System.Drawing.Point(16, 28);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 4;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(89, 28);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 5;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 9);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 13;
            this.lblMarca.Text = "Marca";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Marca A",
            "Marca B",
            "Marca C",
            "Marca D"});
            this.cmbMarca.Location = new System.Drawing.Point(68, 6);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(173, 21);
            this.cmbMarca.TabIndex = 9;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 366);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.mrcOrigen);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cmbMarca);
            this.Name = "frmConsultas";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.RadioButton optAmbos;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbMarca;
    }
}