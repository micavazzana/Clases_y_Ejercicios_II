namespace FormsApp
{
    partial class FrmSimulador
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
            this.lblPoblacionAEvaluar = new System.Windows.Forms.Label();
            this.txtPoblacionAEvaluar = new System.Windows.Forms.TextBox();
            this.cmbMicrorganismo = new System.Windows.Forms.ComboBox();
            this.lblMicrorganismo = new System.Windows.Forms.Label();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.rtbEvolucion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPoblacionAEvaluar
            // 
            this.lblPoblacionAEvaluar.AutoSize = true;
            this.lblPoblacionAEvaluar.Location = new System.Drawing.Point(20, 31);
            this.lblPoblacionAEvaluar.Name = "lblPoblacionAEvaluar";
            this.lblPoblacionAEvaluar.Size = new System.Drawing.Size(110, 15);
            this.lblPoblacionAEvaluar.TabIndex = 0;
            this.lblPoblacionAEvaluar.Text = "Población a evaluar";
            // 
            // txtPoblacionAEvaluar
            // 
            this.txtPoblacionAEvaluar.Location = new System.Drawing.Point(136, 28);
            this.txtPoblacionAEvaluar.Name = "txtPoblacionAEvaluar";
            this.txtPoblacionAEvaluar.Size = new System.Drawing.Size(159, 23);
            this.txtPoblacionAEvaluar.TabIndex = 1;
            // 
            // cmbMicrorganismo
            // 
            this.cmbMicrorganismo.FormattingEnabled = true;
            this.cmbMicrorganismo.Items.AddRange(new object[] {
            "Covid19",
            "Gripe"});
            this.cmbMicrorganismo.Location = new System.Drawing.Point(136, 67);
            this.cmbMicrorganismo.Name = "cmbMicrorganismo";
            this.cmbMicrorganismo.Size = new System.Drawing.Size(159, 23);
            this.cmbMicrorganismo.TabIndex = 2;
            // 
            // lblMicrorganismo
            // 
            this.lblMicrorganismo.AutoSize = true;
            this.lblMicrorganismo.Location = new System.Drawing.Point(20, 70);
            this.lblMicrorganismo.Name = "lblMicrorganismo";
            this.lblMicrorganismo.Size = new System.Drawing.Size(95, 15);
            this.lblMicrorganismo.TabIndex = 3;
            this.lblMicrorganismo.Text = "Microorganismo";
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(368, 40);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(102, 36);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // rtbEvolucion
            // 
            this.rtbEvolucion.Location = new System.Drawing.Point(12, 112);
            this.rtbEvolucion.Name = "rtbEvolucion";
            this.rtbEvolucion.Size = new System.Drawing.Size(516, 326);
            this.rtbEvolucion.TabIndex = 5;
            this.rtbEvolucion.Text = "";
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.rtbEvolucion);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.lblMicrorganismo);
            this.Controls.Add(this.cmbMicrorganismo);
            this.Controls.Add(this.txtPoblacionAEvaluar);
            this.Controls.Add(this.lblPoblacionAEvaluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSimulador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador Pandemia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSimulador_FormClosing);
            this.Load += new System.EventHandler(this.FrmSimulador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoblacionAEvaluar;
        private System.Windows.Forms.TextBox txtPoblacionAEvaluar;
        private System.Windows.Forms.ComboBox cmbMicrorganismo;
        private System.Windows.Forms.Label lblMicrorganismo;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.RichTextBox rtbEvolucion;
    }
}
