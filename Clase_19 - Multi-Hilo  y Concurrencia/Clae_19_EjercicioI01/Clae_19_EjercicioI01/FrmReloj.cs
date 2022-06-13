using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clae_19_EjercicioI01
{
    public delegate void DelegadoActualizaHora(DateTime dt);
    public partial class FrmReloj : Form
    {
        public FrmReloj()
        {
            InitializeComponent();
        }
        private void FrmReloj_Load(object sender, EventArgs e)
        {
            Task.Run(() => IniciarHora());
        }

        private void AsignarHora(DateTime hora)
        {
            if (this.lblHora.InvokeRequired)
            {
                DelegadoActualizaHora delegadoActualizaHora = AsignarHora;
                object[] args = { hora };
                this.BeginInvoke(delegadoActualizaHora, args);
            }
            else
            {
                this.lblHora.Text = hora.ToString();
            }
        }

        private void IniciarHora()
        {
            do
            {
                this.AsignarHora(DateTime.Now);
                Thread.Sleep(1000);
            } while (true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IniciarHora();
        }
    }
}
