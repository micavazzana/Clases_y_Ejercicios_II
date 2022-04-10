namespace Clase_05_Ejercicio_Registrate
{
    partial class FormRegistrate
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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioBtnNoBinario = new System.Windows.Forms.RadioButton();
            this.radioBtnFemenino = new System.Windows.Forms.RadioButton();
            this.radioBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBoxCursos = new System.Windows.Forms.GroupBox();
            this.checkBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxCplusplus = new System.Windows.Forms.CheckBox();
            this.checkBoxCSharp = new System.Windows.Forms.CheckBox();
            this.listBoxPais = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            this.groupBoxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.lblEdad);
            this.groupBoxUser.Controls.Add(this.lblDireccion);
            this.groupBoxUser.Controls.Add(this.lblNombre);
            this.groupBoxUser.Controls.Add(this.numericUpDownEdad);
            this.groupBoxUser.Controls.Add(this.txtBoxDireccion);
            this.groupBoxUser.Controls.Add(this.txtBoxNombre);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 23);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(239, 167);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Detalles del usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(60, 129);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(37, 87);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(106, 125);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(106, 23);
            this.numericUpDownEdad.TabIndex = 2;
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(106, 83);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(106, 23);
            this.txtBoxDireccion.TabIndex = 1;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(106, 42);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(106, 23);
            this.txtBoxNombre.TabIndex = 0;
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioBtnNoBinario);
            this.groupBoxGenero.Controls.Add(this.radioBtnFemenino);
            this.groupBoxGenero.Controls.Add(this.radioBtnMasculino);
            this.groupBoxGenero.Location = new System.Drawing.Point(288, 23);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(126, 117);
            this.groupBoxGenero.TabIndex = 1;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // radioBtnNoBinario
            // 
            this.radioBtnNoBinario.AutoSize = true;
            this.radioBtnNoBinario.Location = new System.Drawing.Point(17, 83);
            this.radioBtnNoBinario.Name = "radioBtnNoBinario";
            this.radioBtnNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radioBtnNoBinario.TabIndex = 2;
            this.radioBtnNoBinario.TabStop = true;
            this.radioBtnNoBinario.Text = "No binario";
            this.radioBtnNoBinario.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemenino
            // 
            this.radioBtnFemenino.AutoSize = true;
            this.radioBtnFemenino.Location = new System.Drawing.Point(17, 55);
            this.radioBtnFemenino.Name = "radioBtnFemenino";
            this.radioBtnFemenino.Size = new System.Drawing.Size(78, 19);
            this.radioBtnFemenino.TabIndex = 1;
            this.radioBtnFemenino.TabStop = true;
            this.radioBtnFemenino.Text = "Femenino";
            this.radioBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // radioBtnMasculino
            // 
            this.radioBtnMasculino.AutoSize = true;
            this.radioBtnMasculino.Location = new System.Drawing.Point(18, 26);
            this.radioBtnMasculino.Name = "radioBtnMasculino";
            this.radioBtnMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioBtnMasculino.TabIndex = 0;
            this.radioBtnMasculino.TabStop = true;
            this.radioBtnMasculino.Text = "Masculino";
            this.radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBoxCursos
            // 
            this.groupBoxCursos.Controls.Add(this.checkBoxJavaScript);
            this.groupBoxCursos.Controls.Add(this.checkBoxCplusplus);
            this.groupBoxCursos.Controls.Add(this.checkBoxCSharp);
            this.groupBoxCursos.Location = new System.Drawing.Point(288, 146);
            this.groupBoxCursos.Name = "groupBoxCursos";
            this.groupBoxCursos.Size = new System.Drawing.Size(126, 113);
            this.groupBoxCursos.TabIndex = 2;
            this.groupBoxCursos.TabStop = false;
            this.groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJavaScript
            // 
            this.checkBoxJavaScript.AutoSize = true;
            this.checkBoxJavaScript.Location = new System.Drawing.Point(18, 81);
            this.checkBoxJavaScript.Name = "checkBoxJavaScript";
            this.checkBoxJavaScript.Size = new System.Drawing.Size(78, 19);
            this.checkBoxJavaScript.TabIndex = 2;
            this.checkBoxJavaScript.Text = "JavaScript";
            this.checkBoxJavaScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxCplusplus
            // 
            this.checkBoxCplusplus.AutoSize = true;
            this.checkBoxCplusplus.Location = new System.Drawing.Point(18, 54);
            this.checkBoxCplusplus.Name = "checkBoxCplusplus";
            this.checkBoxCplusplus.Size = new System.Drawing.Size(50, 19);
            this.checkBoxCplusplus.TabIndex = 1;
            this.checkBoxCplusplus.Text = "C++";
            this.checkBoxCplusplus.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            this.checkBoxCSharp.AutoSize = true;
            this.checkBoxCSharp.Location = new System.Drawing.Point(18, 27);
            this.checkBoxCSharp.Name = "checkBoxCSharp";
            this.checkBoxCSharp.Size = new System.Drawing.Size(41, 19);
            this.checkBoxCSharp.TabIndex = 0;
            this.checkBoxCSharp.Text = "C#";
            this.checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // listBoxPais
            // 
            this.listBoxPais.FormattingEnabled = true;
            this.listBoxPais.ItemHeight = 15;
            this.listBoxPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPais.Location = new System.Drawing.Point(12, 216);
            this.listBoxPais.Name = "listBoxPais";
            this.listBoxPais.Size = new System.Drawing.Size(239, 94);
            this.listBoxPais.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "País";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(288, 278);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(126, 23);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 325);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPais);
            this.Controls.Add(this.groupBoxCursos);
            this.Controls.Add(this.groupBoxGenero);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "FormRegistrate";
            this.Text = "Registro";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.groupBoxCursos.ResumeLayout(false);
            this.groupBoxCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioBtnNoBinario;
        private System.Windows.Forms.RadioButton radioBtnFemenino;
        private System.Windows.Forms.RadioButton radioBtnMasculino;
        private System.Windows.Forms.GroupBox groupBoxCursos;
        private System.Windows.Forms.CheckBox checkBoxJavaScript;
        private System.Windows.Forms.CheckBox checkBoxCplusplus;
        private System.Windows.Forms.CheckBox checkBoxCSharp;
        private System.Windows.Forms.ListBox listBoxPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar;
    }
}
