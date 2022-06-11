using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj
{
    public partial class FrmReloj : Form
    {
        CancellationTokenSource cancelacion;
        public FrmReloj()
        {
            InitializeComponent();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.cancelacion = new CancellationTokenSource();
            CancellationToken cancelar = this.cancelacion.Token;
            Task.Run(() => IniciarReloj(cancelacion), cancelar);
        }
        private void IniciarReloj(CancellationTokenSource cancelacion)
        {
            do
            {
                this.ActualizarHora(DateTime.Now);
                Thread.Sleep(1000);
            }
            while (!cancelacion.IsCancellationRequested);
        }

        private delegate void MiDelegado(DateTime hora);
        
        private void ActualizarHora(DateTime hora)
        {
            //todos los controles de forms, se manejan desde el hilo principal
            //si yo quiero modificar uno de esos controles desde mi hilo secundario:
            //Necesito preguntar si esta queriendo ser cambiado desde otro lado que no sea el hilo principal
            if (this.lblHora.InvokeRequired)  
            {
                MiDelegado callback = new MiDelegado(ActualizarHora);
                object[] argumentos = { hora };
                this.BeginInvoke(callback, argumentos);
                //La primera vez da verdadero y entra al if
                //Entonces uso el begin invoke que va a hacer una llamada recursiva,
                //necesita recibir un delegado(que tiene el metodo llamandolo recursivamente)
                //y ademas si es que mi metodo tiene argumentos
                //necesito declarar un array de objetos donde paso esos argumentos
                
                //Otra forma es declarar in line una nueva action, ya que mi metodo no devolvia nada
                //this.BeginInvoke(new Action(() => ActualizarHora(date)));
            }
            else//Entra al else desde la llamada que hace el BeginInvoke, entonces modifica el control
            {
                this.lblHora.Text = $"{ hora }";
            }            
        } 

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.cancelacion.Cancel();
        }
    }
}
