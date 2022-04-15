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
            if (String.IsNullOrWhiteSpace(this.txtBoxNombre.Text) && String.IsNullOrWhiteSpace(this.txtBoxApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtBoxNombre.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(this.txtBoxApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormularioSaludar frmSaludo = new FormularioSaludar($"Soy {this.txtBoxNombre.Text} {this.txtBoxApellido.Text} y mi materia favorita es {this.cmbMateriaFav.Text}");
                frmSaludo.ShowDialog();
            }
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFav.Items.Add("Programación II");
            this.cmbMateriaFav.Items.Add("Laboratorio II");
            this.cmbMateriaFav.SelectedIndex = 0;
        }
    }
}
