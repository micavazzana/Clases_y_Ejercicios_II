using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_05_Ejercicios
{
    public partial class FormularioSaludar : Form
    {
        public FormularioSaludar()
        {
            InitializeComponent();
        }

        public FormularioSaludar(string nombreApellido) : this()
        {
            this.lblNombreApellido.Text = nombreApellido;
        }
    }
}
