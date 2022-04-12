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
        bool flag = true;
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                btnLockCotizacion.ImageIndex = 1;
                flag = false;
                txtBoxCotizacionDolar.Enabled = true;
                txtBoxCotizacionEuro.Enabled = true;
                txtBoxCotizacionPeso.Enabled = true;
            }
            else
            {
                btnLockCotizacion.ImageIndex = 0;
                flag = true;
                txtBoxCotizacionDolar.Enabled = false;
                txtBoxCotizacionEuro.Enabled = false;
                txtBoxCotizacionPeso.Enabled = false;
            }
        }
    }
}
