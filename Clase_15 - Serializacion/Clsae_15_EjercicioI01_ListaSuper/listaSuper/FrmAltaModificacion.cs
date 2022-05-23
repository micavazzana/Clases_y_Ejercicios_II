using System;
using System.Windows.Forms;

namespace listaSuper
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion()
        {
            InitializeComponent();
        }
        public FrmAltaModificacion(string title, string txtObjeto, string btnConfirmar) : this()
        {
            this.Text = title;
            this.txtObjeto.Text = txtObjeto;
            this.btnConfirmar.Text = btnConfirmar;
        }

        public string Objeto
        {
            get
            {
                return this.txtObjeto.Text;
            }
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txtObjeto.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar algo");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnConfirmar_Click(sender, e);
            }
            else if (e.KeyChar == (char)27)
            {
                btnCancelar_Click(sender, e);
            }
        }
    }
}
