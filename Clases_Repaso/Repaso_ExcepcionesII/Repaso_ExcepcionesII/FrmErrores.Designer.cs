namespace Repaso_ExcepcionesII
{
    partial class FrmErrores
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
            this.listErrores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listErrores
            // 
            this.listErrores.FormattingEnabled = true;
            this.listErrores.ItemHeight = 15;
            this.listErrores.Location = new System.Drawing.Point(12, 12);
            this.listErrores.Name = "listErrores";
            this.listErrores.Size = new System.Drawing.Size(372, 424);
            this.listErrores.TabIndex = 0;
            // 
            // FrmErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 446);
            this.Controls.Add(this.listErrores);
            this.Name = "FrmErrores";
            this.Text = "FrmErrores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listErrores;
    }
}