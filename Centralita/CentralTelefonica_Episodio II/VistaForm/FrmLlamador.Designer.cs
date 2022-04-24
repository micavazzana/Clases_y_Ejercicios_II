namespace VistaForm
{
    partial class FrmLlamador
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
            this.txtNroDestino = new System.Windows.Forms.TextBox();
            this.gBoxPanel = new System.Windows.Forms.GroupBox();
            this.btnNumeral = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAsterisco = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNroOrigen = new System.Windows.Forms.TextBox();
            this.cmbFranja = new System.Windows.Forms.ComboBox();
            this.gBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDestino
            // 
            this.txtNroDestino.Location = new System.Drawing.Point(29, 30);
            this.txtNroDestino.Name = "txtNroDestino";
            this.txtNroDestino.Size = new System.Drawing.Size(302, 23);
            this.txtNroDestino.TabIndex = 0;
            this.txtNroDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroDestino.TextChanged += new System.EventHandler(this.txtNroDestino_TextChanged);
            // 
            // gBoxPanel
            // 
            this.gBoxPanel.Controls.Add(this.btnNumeral);
            this.gBoxPanel.Controls.Add(this.btn0);
            this.gBoxPanel.Controls.Add(this.btnAsterisco);
            this.gBoxPanel.Controls.Add(this.btn9);
            this.gBoxPanel.Controls.Add(this.btn8);
            this.gBoxPanel.Controls.Add(this.btn7);
            this.gBoxPanel.Controls.Add(this.btn6);
            this.gBoxPanel.Controls.Add(this.btn5);
            this.gBoxPanel.Controls.Add(this.btn4);
            this.gBoxPanel.Controls.Add(this.btn3);
            this.gBoxPanel.Controls.Add(this.btn2);
            this.gBoxPanel.Controls.Add(this.btn1);
            this.gBoxPanel.Location = new System.Drawing.Point(29, 76);
            this.gBoxPanel.Name = "gBoxPanel";
            this.gBoxPanel.Size = new System.Drawing.Size(166, 218);
            this.gBoxPanel.TabIndex = 1;
            this.gBoxPanel.TabStop = false;
            this.gBoxPanel.Text = "Panel";
            // 
            // btnNumeral
            // 
            this.btnNumeral.Location = new System.Drawing.Point(111, 163);
            this.btnNumeral.Name = "btnNumeral";
            this.btnNumeral.Size = new System.Drawing.Size(43, 41);
            this.btnNumeral.TabIndex = 11;
            this.btnNumeral.Text = "#";
            this.btnNumeral.UseVisualStyleBackColor = true;
            this.btnNumeral.Click += new System.EventHandler(this.btnNumeral_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(62, 163);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(43, 41);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnAsterisco
            // 
            this.btnAsterisco.Location = new System.Drawing.Point(13, 163);
            this.btnAsterisco.Name = "btnAsterisco";
            this.btnAsterisco.Size = new System.Drawing.Size(43, 41);
            this.btnAsterisco.TabIndex = 9;
            this.btnAsterisco.Text = "*";
            this.btnAsterisco.UseVisualStyleBackColor = true;
            this.btnAsterisco.Click += new System.EventHandler(this.btnAsterisco_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(111, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(43, 41);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(62, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(43, 41);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(43, 41);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(111, 69);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(43, 41);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(62, 69);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(43, 41);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 69);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(43, 41);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(111, 22);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(43, 41);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(62, 22);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(43, 41);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 22);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(43, 41);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(211, 92);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(120, 47);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "Llamar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(211, 149);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 47);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(211, 239);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 47);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNroOrigen
            // 
            this.txtNroOrigen.Location = new System.Drawing.Point(211, 207);
            this.txtNroOrigen.Name = "txtNroOrigen";
            this.txtNroOrigen.Size = new System.Drawing.Size(120, 23);
            this.txtNroOrigen.TabIndex = 5;
            // 
            // cmbFranja
            // 
            this.cmbFranja.FormattingEnabled = true;
            this.cmbFranja.Items.AddRange(new object[] {
            "Franja_1",
            "Franja_2",
            "Franja_3"});
            this.cmbFranja.Location = new System.Drawing.Point(29, 309);
            this.cmbFranja.Name = "cmbFranja";
            this.cmbFranja.Size = new System.Drawing.Size(302, 23);
            this.cmbFranja.TabIndex = 6;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 359);
            this.Controls.Add(this.cmbFranja);
            this.Controls.Add(this.txtNroOrigen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.gBoxPanel);
            this.Controls.Add(this.txtNroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.gBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroDestino;
        private System.Windows.Forms.GroupBox gBoxPanel;
        private System.Windows.Forms.Button btnNumeral;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAsterisco;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNroOrigen;
        private System.Windows.Forms.ComboBox cmbFranja;
    }
}