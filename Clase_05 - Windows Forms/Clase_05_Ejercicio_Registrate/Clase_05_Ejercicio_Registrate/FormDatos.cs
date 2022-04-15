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

namespace Clase_05_Ejercicio_Registrate
{
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }
        public FormDatos(Ingresante i) :this()
        {
            this.lblDatos.Text = i.Mostrar();
        }
    }
}
