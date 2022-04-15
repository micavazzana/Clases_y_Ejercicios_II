using Billetes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_05_EjercicioCotizador
{
    public partial class FormConversor : Form
    {
        bool flag;

        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.flag)
            {
                btnLockCotizacion.ImageIndex = 1;
                this.flag = false;
                //txtBoxCotizacionDolar.Enabled = true;
                txtBoxCotizacionEuro.Enabled = true;
                txtBoxCotizacionPeso.Enabled = true;
            }
            else
            {
                btnLockCotizacion.ImageIndex = 0;
                this.flag = true;
                //txtBoxCotizacionDolar.Enabled = false;
                txtBoxCotizacionEuro.Enabled = false;
                txtBoxCotizacionPeso.Enabled = false;
            }
        }

        private void FormConversor_Load(object sender, EventArgs e)
        {
            this.flag = false;
            btnLockCotizacion.ImageIndex = 1;
            txtBoxCotizacionDolar.Text = "1";
            txtBoxCotizacionDolar.Enabled = false;
            txtBoxCotizacionEuro.Enabled = true;
            txtBoxCotizacionPeso.Enabled = true;
        }

        private void txtBoxCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotizacionEuro;
            if (double.TryParse(this.txtBoxCotizacionEuro.Text, out cotizacionEuro) && cotizacionEuro > 0)
            {
                Euro.SetCotizacion(cotizacionEuro);
            }
            else
            {
                this.txtBoxCotizacionEuro.Focus();
                this.flag = true;
            }
        }
        private void txtBoxCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotizacionPeso;
            if (double.TryParse(this.txtBoxCotizacionPeso.Text, out cotizacionPeso) && cotizacionPeso > 0)
            {
                Peso.SetCotizacion(cotizacionPeso);
            }
            else
            {
                this.txtBoxCotizacionPeso.Focus();
                this.flag = true;
            }
        }
        /*
        private void txtBoxCotizacionDolar_Leave(object sender, EventArgs e)
        {
            LostFocus += new EventHandler(FormConversor_LostFocus);
        }
        private void FormConversor_LostFocus(object sender, EventArgs e)
        {

        }*/
        
        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxEuro.Text))
            {
                double cantidad = double.Parse(this.txtBoxEuro.Text);
                this.txtBoxEuroAEuro.Text = new Euro(cantidad).GetCantidad().ToString();
                this.txtBoxEuroADolar.Text = ((Dolar)new Euro(cantidad)).GetCantidad().ToString();
                this.txtBoxEuroAPeso.Text = ((Peso)new Euro(cantidad)).GetCantidad().ToString();
            }
        }
        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxDolar.Text))
            {
                double cantidad = double.Parse(this.txtBoxDolar.Text);
                this.txtBoxDolarAEuro.Text = ((Euro)new Dolar(cantidad)).GetCantidad().ToString();
                this.txtBoxDolarADolar.Text = new Dolar(cantidad).GetCantidad().ToString();
                this.txtBoxDolarAPeso.Text = ((Peso)new Dolar(cantidad)).GetCantidad().ToString();
            }
        }
        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtBoxPeso.Text))
            {
                double cantidad = double.Parse(this.txtBoxPeso.Text);
                this.txtBoxPesoAEuro.Text = ((Euro)new Peso(cantidad)).GetCantidad().ToString();
                this.txtBoxPesoADolar.Text = ((Dolar)new Peso(cantidad)).GetCantidad().ToString();
                this.txtBoxPesoAPeso.Text = new Peso(cantidad).GetCantidad().ToString();
            }
        }
    }
}
