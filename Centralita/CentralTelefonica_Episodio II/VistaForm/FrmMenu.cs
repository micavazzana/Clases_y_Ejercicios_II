using System.Windows.Forms;
using _Centralita;

namespace VistaForm
{
    public partial class FrmMenu : Form
    {
        private Centralita central;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, System.EventArgs e)
        {
            central = new Centralita();
            FrmLlamador frmLlamador = new FrmLlamador(central);
            frmLlamador.ShowDialog();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
