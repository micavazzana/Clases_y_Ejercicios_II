using BibliotecaUniversidad;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Repaso_ExcepcionesII
{
    public partial class FrmMenu : Form
    {
        List<string> errores = new();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnMostraAlumnos_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = String.Empty;
            this.errores.Add("Errores Alumnos");
            foreach (Alumno item in Universidad.Alumnos)
            {
                try
                {
                    rtbDatos.Text += item.ToString() + "\n";
                }
                catch (Exception ex)
                {
                    this.errores.Add(ex.Message);
                }
            }
        }

        private void btnMostrarProfesores_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = String.Empty;
            this.errores.Add("Errores Profesores");
            foreach (Profesor item in Universidad.Profesores)
            {
                try
                {
                    rtbDatos.Text += item.ToString() + "\n";
                }
                catch (Exception ex)
                {
                    this.errores.Add(ex.Message);
                }
            }
        }

        private void btnMostrarMaterias_Click(object sender, EventArgs e)
        {
            rtbDatos.Text = String.Empty;
            this.errores.Add("Errores Materias");
            foreach (Materia item in Universidad.Materias)
            {
                try
                {
                    rtbDatos.Text += item.ToString() + "\n";
                }
                catch (Exception ex)
                {
                    this.errores.Add(ex.Message);
                }
            }
        }

        private void btnMostrarErrores_Click(object sender, EventArgs e)
        {
            FrmErrores frm = new FrmErrores(this.errores);
            frm.ShowDialog();
        }
    }
}
