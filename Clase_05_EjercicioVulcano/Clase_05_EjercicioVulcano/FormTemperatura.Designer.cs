namespace Clase_05_EjercicioVulcano
{
    partial class FormTemperatura
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
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblFahrenheit2 = new System.Windows.Forms.Label();
            this.lblCelsius2 = new System.Windows.Forms.Label();
            this.lblKelvin2 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnConvertirFahrenheit = new System.Windows.Forms.Button();
            this.btnConvertirCelsius = new System.Windows.Forms.Button();
            this.btnConvertirKelvin = new System.Windows.Forms.Button();
            this.txtFahrenheitAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(31, 56);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(63, 15);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(50, 90);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(44, 15);
            this.lblCelsius.TabIndex = 1;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(55, 123);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(39, 15);
            this.lblKelvin.TabIndex = 2;
            this.lblKelvin.Text = "Kelvin";
            // 
            // lblFahrenheit2
            // 
            this.lblFahrenheit2.AutoSize = true;
            this.lblFahrenheit2.Location = new System.Drawing.Point(322, 25);
            this.lblFahrenheit2.Name = "lblFahrenheit2";
            this.lblFahrenheit2.Size = new System.Drawing.Size(63, 15);
            this.lblFahrenheit2.TabIndex = 3;
            this.lblFahrenheit2.Text = "Fahrenheit";
            // 
            // lblCelsius2
            // 
            this.lblCelsius2.AutoSize = true;
            this.lblCelsius2.Location = new System.Drawing.Point(445, 25);
            this.lblCelsius2.Name = "lblCelsius2";
            this.lblCelsius2.Size = new System.Drawing.Size(44, 15);
            this.lblCelsius2.TabIndex = 4;
            this.lblCelsius2.Text = "Celsius";
            // 
            // lblKelvin2
            // 
            this.lblKelvin2.AutoSize = true;
            this.lblKelvin2.Location = new System.Drawing.Point(558, 25);
            this.lblKelvin2.Name = "lblKelvin2";
            this.lblKelvin2.Size = new System.Drawing.Size(39, 15);
            this.lblKelvin2.TabIndex = 5;
            this.lblKelvin2.Text = "Kelvin";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(105, 53);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheit.TabIndex = 6;
            this.txtFahrenheit.Leave += new System.EventHandler(this.txtFahrenheit_Leave);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(105, 87);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 23);
            this.txtCelsius.TabIndex = 7;
            this.txtCelsius.Leave += new System.EventHandler(this.txtCelsius_Leave);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(105, 120);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtKelvin.TabIndex = 8;
            this.txtKelvin.Leave += new System.EventHandler(this.txtKelvin_Leave);
            // 
            // btnConvertirFahrenheit
            // 
            this.btnConvertirFahrenheit.Location = new System.Drawing.Point(215, 53);
            this.btnConvertirFahrenheit.Name = "btnConvertirFahrenheit";
            this.btnConvertirFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirFahrenheit.TabIndex = 9;
            this.btnConvertirFahrenheit.Text = ">";
            this.btnConvertirFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirFahrenheit.Click += new System.EventHandler(this.btnConvertirFahrenheit_Click);
            // 
            // btnConvertirCelsius
            // 
            this.btnConvertirCelsius.Location = new System.Drawing.Point(215, 87);
            this.btnConvertirCelsius.Name = "btnConvertirCelsius";
            this.btnConvertirCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirCelsius.TabIndex = 10;
            this.btnConvertirCelsius.Text = ">";
            this.btnConvertirCelsius.UseVisualStyleBackColor = true;
            this.btnConvertirCelsius.Click += new System.EventHandler(this.btnConvertirCelsius_Click);
            // 
            // btnConvertirKelvin
            // 
            this.btnConvertirKelvin.Location = new System.Drawing.Point(215, 120);
            this.btnConvertirKelvin.Name = "btnConvertirKelvin";
            this.btnConvertirKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirKelvin.TabIndex = 11;
            this.btnConvertirKelvin.Text = ">";
            this.btnConvertirKelvin.UseVisualStyleBackColor = true;
            this.btnConvertirKelvin.Click += new System.EventHandler(this.btnConvertirKelvin_Click);
            // 
            // txtFahrenheitAFahrenheit
            // 
            this.txtFahrenheitAFahrenheit.Enabled = false;
            this.txtFahrenheitAFahrenheit.Location = new System.Drawing.Point(305, 53);
            this.txtFahrenheitAFahrenheit.Name = "txtFahrenheitAFahrenheit";
            this.txtFahrenheitAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheitAFahrenheit.TabIndex = 12;
            // 
            // txtCelsiusAFahrenheit
            // 
            this.txtCelsiusAFahrenheit.Enabled = false;
            this.txtCelsiusAFahrenheit.Location = new System.Drawing.Point(305, 87);
            this.txtCelsiusAFahrenheit.Name = "txtCelsiusAFahrenheit";
            this.txtCelsiusAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusAFahrenheit.TabIndex = 13;
            // 
            // txtKelvinAFahrenheit
            // 
            this.txtKelvinAFahrenheit.Enabled = false;
            this.txtKelvinAFahrenheit.Location = new System.Drawing.Point(305, 120);
            this.txtKelvinAFahrenheit.Name = "txtKelvinAFahrenheit";
            this.txtKelvinAFahrenheit.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinAFahrenheit.TabIndex = 14;
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Enabled = false;
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(416, 53);
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheitACelsius.TabIndex = 15;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Enabled = false;
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(416, 88);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusACelsius.TabIndex = 16;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Enabled = false;
            this.txtKelvinACelsius.Location = new System.Drawing.Point(416, 120);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinACelsius.TabIndex = 17;
            // 
            // txtFahrenheitAKelvin
            // 
            this.txtFahrenheitAKelvin.Enabled = false;
            this.txtFahrenheitAKelvin.Location = new System.Drawing.Point(526, 53);
            this.txtFahrenheitAKelvin.Name = "txtFahrenheitAKelvin";
            this.txtFahrenheitAKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtFahrenheitAKelvin.TabIndex = 18;
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Enabled = false;
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(526, 88);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtCelsiusAKelvin.TabIndex = 19;
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Enabled = false;
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(526, 121);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(100, 23);
            this.txtKelvinAKelvin.TabIndex = 20;
            // 
            // FormTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 174);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtFahrenheitAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.txtKelvinAFahrenheit);
            this.Controls.Add(this.txtCelsiusAFahrenheit);
            this.Controls.Add(this.txtFahrenheitAFahrenheit);
            this.Controls.Add(this.btnConvertirKelvin);
            this.Controls.Add(this.btnConvertirCelsius);
            this.Controls.Add(this.btnConvertirFahrenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.lblKelvin2);
            this.Controls.Add(this.lblCelsius2);
            this.Controls.Add(this.lblFahrenheit2);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemperatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vulcano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblFahrenheit2;
        private System.Windows.Forms.Label lblCelsius2;
        private System.Windows.Forms.Label lblKelvin2;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnConvertirFahrenheit;
        private System.Windows.Forms.Button btnConvertirCelsius;
        private System.Windows.Forms.Button btnConvertirKelvin;
        private System.Windows.Forms.TextBox txtFahrenheitAFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenheit;
        private System.Windows.Forms.TextBox txtKelvinAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
    }
}
