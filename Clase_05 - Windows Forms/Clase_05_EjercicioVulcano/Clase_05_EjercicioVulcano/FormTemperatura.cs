using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahrenheit451;

namespace Clase_05_EjercicioVulcano
{
    public partial class FormTemperatura : Form
    {
        public FormTemperatura()
        {
            InitializeComponent();
        }

        private void btnConvertirFahrenheit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFahrenheit.Text))
            {
                double grados = double.Parse(this.txtFahrenheit.Text);
                this.txtFahrenheitAFahrenheit.Text = new Fahrenheit(grados).GetGrados().ToString();
                this.txtFahrenheitACelsius.Text = ((Celsius)new Fahrenheit(grados)).GetGrados().ToString();
                this.txtFahrenheitAKelvin.Text = ((Kelvin)new Fahrenheit(grados)).GetGrados().ToString();
            }
        }

        private void btnConvertirCelsius_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCelsius.Text))
            {
                double grados = double.Parse(this.txtCelsius.Text);
                this.txtCelsiusAFahrenheit.Text = ((Fahrenheit)new Celsius(grados)).GetGrados().ToString();
                this.txtCelsiusACelsius.Text = new Celsius(grados).GetGrados().ToString();
                this.txtCelsiusAKelvin.Text = ((Kelvin)new Celsius(grados)).GetGrados().ToString();
            }
        }

        private void btnConvertirKelvin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtKelvin.Text))
            {
                double grados = double.Parse(this.txtKelvin.Text);
                this.txtKelvinAFahrenheit.Text = ((Fahrenheit)new Kelvin(grados)).GetGrados().ToString();
                this.txtKelvinACelsius.Text = ((Celsius)new Kelvin(grados)).GetGrados().ToString();
                this.txtKelvinAKelvin.Text = new Kelvin(grados).GetGrados().ToString();
            }
        }

        private void txtFahrenheit_Leave(object sender, EventArgs e)
        {
            double grados;
            if(!double.TryParse(this.txtFahrenheit.Text, out grados))
            {
                this.txtFahrenheit.Focus();
            }
        }

        private void txtCelsius_Leave(object sender, EventArgs e)
        {
            double grados;
            if (!double.TryParse(this.txtCelsius.Text, out grados))
            {
                this.txtCelsius.Focus();
            }
        }

        private void txtKelvin_Leave(object sender, EventArgs e)
        {
            double grados;
            if (!double.TryParse(this.txtKelvin.Text, out grados))
            {
                this.txtKelvin.Focus();
            }
        }
    }
}
