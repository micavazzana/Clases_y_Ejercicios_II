using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_05
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }
        private void Frm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar el formulario?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado != DialogResult.Yes)
                {
                    e.Cancel = true;//esto impide que cierre el form
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();//el close llama al form closing
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string text = this.richTextBox1.Text;
            MessageBox.Show(text);
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            TextBox txtNuevo = new TextBox();
            txtNuevo.Text = "Hola mundo";
            txtNuevo.Location = new Point(550, 350);
            txtNuevo.Name = "txtAgregado";
            this.Controls.Add(txtNuevo);
        }
    }
}
