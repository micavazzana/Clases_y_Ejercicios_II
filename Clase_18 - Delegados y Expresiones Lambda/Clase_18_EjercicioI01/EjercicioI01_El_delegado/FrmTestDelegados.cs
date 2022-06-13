using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01_El_delegado
{
    
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizarNombreDelegado(string nombre);
        private ActualizarNombreDelegado actualizaNombre;
        public FrmTestDelegados(ActualizarNombreDelegado delegado)
        {
            this.actualizaNombre = delegado;
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizaNombre.Invoke(this.txtNombre.Text);
        }
    }
}
