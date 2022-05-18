using BibliotecaUniversidad;
using System;
using System.Windows.Forms;

namespace Repaso_ExcepcionesII
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Universidad.Loguear(int.Parse(this.txtUser.Text), this.txtPassword.Text))
                {
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.ShowDialog();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("El campo no puede estar vacio");
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato es errado");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.txtUser.Text = "123123";
            this.txtPassword.Text = "lucas123";
        }
    }
}
