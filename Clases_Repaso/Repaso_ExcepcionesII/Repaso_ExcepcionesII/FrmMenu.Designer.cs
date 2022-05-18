namespace Repaso_ExcepcionesII
{
    partial class FrmMenu
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
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.btnMostraAlumnos = new System.Windows.Forms.Button();
            this.btnMostrarProfesores = new System.Windows.Forms.Button();
            this.btnMostrarMaterias = new System.Windows.Forms.Button();
            this.btnMostrarErrores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(22, 24);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(303, 406);
            this.rtbDatos.TabIndex = 0;
            this.rtbDatos.Text = "";
            // 
            // btnMostraAlumnos
            // 
            this.btnMostraAlumnos.Location = new System.Drawing.Point(368, 38);
            this.btnMostraAlumnos.Name = "btnMostraAlumnos";
            this.btnMostraAlumnos.Size = new System.Drawing.Size(124, 36);
            this.btnMostraAlumnos.TabIndex = 1;
            this.btnMostraAlumnos.Text = "Mostrar Alumnos";
            this.btnMostraAlumnos.UseVisualStyleBackColor = true;
            this.btnMostraAlumnos.Click += new System.EventHandler(this.btnMostraAlumnos_Click);
            // 
            // btnMostrarProfesores
            // 
            this.btnMostrarProfesores.Location = new System.Drawing.Point(368, 91);
            this.btnMostrarProfesores.Name = "btnMostrarProfesores";
            this.btnMostrarProfesores.Size = new System.Drawing.Size(124, 36);
            this.btnMostrarProfesores.TabIndex = 2;
            this.btnMostrarProfesores.Text = "Mostrar Profesores";
            this.btnMostrarProfesores.UseVisualStyleBackColor = true;
            this.btnMostrarProfesores.Click += new System.EventHandler(this.btnMostrarProfesores_Click);
            // 
            // btnMostrarMaterias
            // 
            this.btnMostrarMaterias.Location = new System.Drawing.Point(368, 146);
            this.btnMostrarMaterias.Name = "btnMostrarMaterias";
            this.btnMostrarMaterias.Size = new System.Drawing.Size(124, 36);
            this.btnMostrarMaterias.TabIndex = 3;
            this.btnMostrarMaterias.Text = "Mostrar Materias";
            this.btnMostrarMaterias.UseVisualStyleBackColor = true;
            this.btnMostrarMaterias.Click += new System.EventHandler(this.btnMostrarMaterias_Click);
            // 
            // btnMostrarErrores
            // 
            this.btnMostrarErrores.Location = new System.Drawing.Point(400, 382);
            this.btnMostrarErrores.Name = "btnMostrarErrores";
            this.btnMostrarErrores.Size = new System.Drawing.Size(92, 48);
            this.btnMostrarErrores.TabIndex = 4;
            this.btnMostrarErrores.Text = "Mostrar Errores";
            this.btnMostrarErrores.UseVisualStyleBackColor = true;
            this.btnMostrarErrores.Click += new System.EventHandler(this.btnMostrarErrores_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 448);
            this.Controls.Add(this.btnMostrarErrores);
            this.Controls.Add(this.btnMostrarMaterias);
            this.Controls.Add(this.btnMostrarProfesores);
            this.Controls.Add(this.btnMostraAlumnos);
            this.Controls.Add(this.rtbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDatos;
        private System.Windows.Forms.Button btnMostraAlumnos;
        private System.Windows.Forms.Button btnMostrarProfesores;
        private System.Windows.Forms.Button btnMostrarMaterias;
        private System.Windows.Forms.Button btnMostrarErrores;
    }
}