using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmDt : Form
    {
        DirectorTecnico dt;
        public FrmDt()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(this.textBoxNombre.Text, this.textBoxApellido.Text, (int)this.numericUpDownEdad.Value, (int)this.numericUpDownDni.Value,(int)this.numericUpDownExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!");
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if(this.dt is null)
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario!");
            }
            else if(dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto!");
            }
            else
            {
                MessageBox.Show("El DT no es apto!");
            }
        }
    }
}
