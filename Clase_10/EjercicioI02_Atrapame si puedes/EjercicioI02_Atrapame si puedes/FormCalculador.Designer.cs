namespace EjercicioI02_Atrapame_si_puedes
{
    partial class FormCalculador
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
            this.lblKm = new System.Windows.Forms.Label();
            this.lblLts = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtLts = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(31, 36);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(64, 15);
            this.lblKm.TabIndex = 0;
            this.lblKm.Text = "Kilometros";
            // 
            // lblLts
            // 
            this.lblLts.AutoSize = true;
            this.lblLts.Location = new System.Drawing.Point(31, 97);
            this.lblLts.Name = "lblLts";
            this.lblLts.Size = new System.Drawing.Size(36, 15);
            this.lblLts.TabIndex = 1;
            this.lblLts.Text = "Litros";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(31, 54);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(152, 23);
            this.txtKm.TabIndex = 2;
            // 
            // txtLts
            // 
            this.txtLts.Location = new System.Drawing.Point(31, 115);
            this.txtLts.Name = "txtLts";
            this.txtLts.Size = new System.Drawing.Size(152, 23);
            this.txtLts.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(31, 164);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 35);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Enabled = false;
            this.rtbResultado.Location = new System.Drawing.Point(260, 33);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(193, 172);
            this.rtbResultado.TabIndex = 5;
            this.rtbResultado.Text = "";
            // 
            // FormCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 240);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLts);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.lblLts);
            this.Controls.Add(this.lblKm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblLts;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtLts;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}
