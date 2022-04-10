using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_05_Ejercicio_Registrate
{
    public partial class FormRegistrate : Form
    {
        public FormRegistrate()
        {
            InitializeComponent();
        }     
        private void button1_Click(object sender, EventArgs e)
        {
            Ingresante ingresante = new Ingresante(this.txtBoxNombre.Text,this.txtBoxDireccion.Text,(int)this.numericUpDownEdad.Value,radioButtonSeleccionado(), cursosSeleccionados(), this.listBoxPais.Text);
            FormDatos formDatos = new FormDatos(ingresante);
            formDatos.Show();
        }
        private string radioButtonSeleccionado()
        {
            string genero;

            if (this.radioBtnFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (this.radioBtnMasculino.Checked)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "No Binario";
            }
            return genero;
        }
        private string[] cursosSeleccionados()
        {
            string[] cursos = new string[3];
            if (this.checkBoxCSharp.Checked)
            {
                cursos[0] = "C#";
            }
            if (this.checkBoxCplusplus.Checked)
            {
                cursos[1] = "C++";
            }
            if (this.checkBoxJavaScript.Checked)
            {
                cursos[2] = "JavaScript";
            }
            return cursos;
        }
    }
}
