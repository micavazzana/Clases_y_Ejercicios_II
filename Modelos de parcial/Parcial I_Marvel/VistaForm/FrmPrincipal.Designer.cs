namespace VistaForm
{
    partial class FrmPrincipal
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
            this.btnMostrarPersonajes = new System.Windows.Forms.Button();
            this.rtbPersonajes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMostrarPersonajes
            // 
            this.btnMostrarPersonajes.Location = new System.Drawing.Point(189, 21);
            this.btnMostrarPersonajes.Name = "btnMostrarPersonajes";
            this.btnMostrarPersonajes.Size = new System.Drawing.Size(206, 44);
            this.btnMostrarPersonajes.TabIndex = 0;
            this.btnMostrarPersonajes.Text = "Mostrar Personajes";
            this.btnMostrarPersonajes.UseVisualStyleBackColor = true;
            this.btnMostrarPersonajes.Click += new System.EventHandler(this.btnMostrarPersonajes_Click);
            // 
            // rtbPersonajes
            // 
            this.rtbPersonajes.Location = new System.Drawing.Point(12, 83);
            this.rtbPersonajes.Name = "rtbPersonajes";
            this.rtbPersonajes.Size = new System.Drawing.Size(560, 355);
            this.rtbPersonajes.TabIndex = 1;
            this.rtbPersonajes.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 453);
            this.Controls.Add(this.rtbPersonajes);
            this.Controls.Add(this.btnMostrarPersonajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vazzana.Micaela.2E";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPersonajes;
        private System.Windows.Forms.RichTextBox rtbPersonajes;
    }
}
