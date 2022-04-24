namespace VistaForm
{
    partial class FrmEstacionamiento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cmbTipoMoto = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstVehiculos = new System.Windows.Forms.ListBox();
            this.txtNombreEstacionamiento = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(117, 56);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoVehiculo.TabIndex = 0;
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(117, 85);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(121, 23);
            this.txtPatente.TabIndex = 1;
            // 
            // cmbTipoMoto
            // 
            this.cmbTipoMoto.FormattingEnabled = true;
            this.cmbTipoMoto.Location = new System.Drawing.Point(117, 114);
            this.cmbTipoMoto.Name = "cmbTipoMoto";
            this.cmbTipoMoto.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoMoto.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(117, 143);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 23);
            this.txtMarca.TabIndex = 3;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(33, 59);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(78, 15);
            this.lblTipoVehiculo.TabIndex = 4;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(64, 88);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(47, 15);
            this.lblPatente.TabIndex = 5;
            this.lblPatente.Text = "Patente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(117, 172);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 51);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Vehiculo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstVehiculos
            // 
            this.lstVehiculos.FormattingEnabled = true;
            this.lstVehiculos.ItemHeight = 15;
            this.lstVehiculos.Location = new System.Drawing.Point(267, 59);
            this.lstVehiculos.Name = "lstVehiculos";
            this.lstVehiculos.Size = new System.Drawing.Size(382, 229);
            this.lstVehiculos.TabIndex = 8;
            this.lstVehiculos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstVehiculos_MouseDoubleClick);
            // 
            // txtNombreEstacionamiento
            // 
            this.txtNombreEstacionamiento.Location = new System.Drawing.Point(267, 23);
            this.txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            this.txtNombreEstacionamiento.Size = new System.Drawing.Size(382, 23);
            this.txtNombreEstacionamiento.TabIndex = 9;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(50, 117);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 15);
            this.lblTipo.TabIndex = 10;
            // 
            // FrmEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 315);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombreEstacionamiento);
            this.Controls.Add(this.lstVehiculos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cmbTipoMoto);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            this.Load += new System.EventHandler(this.FrmEstacionamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ComboBox cmbTipoMoto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstVehiculos;
        private System.Windows.Forms.TextBox txtNombreEstacionamiento;
        private System.Windows.Forms.Label lblTipo;
    }
}
