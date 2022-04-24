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
    public partial class frmVista : Form
    {
        Curso curso;

        public frmVista()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            this.curso = new Curso((short)this.nudAnioCurso.Value, (Divisiones)this.cmbDivisionCurso.SelectedValue, new Profesor(this.txtNombreProfe.Text, this.txtApellidoProfe.Text, this.txtDocumentoProfe.Text, this.dtpFechaIngreso.Value));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.rtbDatos.Text = (string)curso;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            curso +=(new Alumno(this.txtNombre.Text,this.txtApellido.Text,this.txtDocumento.Text,(short)this.nudAnio.Value, (Divisiones)this.cmbDivision.SelectedValue));
        }

        private void frmVista_Load(object sender, EventArgs e)
        {
            this.cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            this.cmbDivision.DataSource = Enum.GetValues(typeof(Divisiones));
            Divisiones division;
            Enum.TryParse<Divisiones>(this.cmbDivisionCurso.SelectedValue.ToString(), out division);
        }
    }
}
