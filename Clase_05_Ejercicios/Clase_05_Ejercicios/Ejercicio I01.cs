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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            FormularioSaludar frmSaludo = new FormularioSaludar($"Soy {this.txtBoxNombre.Text} {this.txtBoxApellido.Text} y mi materia favorita es {this.cmbMateriaFav.Text}");
            frmSaludo.ShowDialog();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFav.Items.Add("Progra II");
            this.cmbMateriaFav.Items.Add("Labo II");
            this.cmbMateriaFav.SelectedIndex = 0;
        }

    }
}
