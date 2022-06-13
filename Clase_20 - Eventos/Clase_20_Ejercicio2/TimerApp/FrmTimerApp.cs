using Entidades;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * EJERCICIO 2
 * Escriba un programa de alarma de cuenta regresiva
 * para notificar a cualquier persona interesada que ha pasado 
 * la cantidad de tiempo designada. 
 * Necesitará una clase para simular el reloj de cuenta regresiva 
 * que acepta un mensaje y una cantidad de segundos de espera (proporcionada por el usuario). 
 * Después de esperar el tiempo apropiado, el reloj de cuenta regresiva debe informar 
 * que se cumplió el tiempo (Cuando esté calculando el tiempo de espera, 
 * recuerde que Thread.Sleep( )toma un argumento en milisegundos ).
 */
namespace TimerApp
{
    public partial class FrmTimerApp : Form
    {
        private Temporizador temporizador;
        public FrmTimerApp()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.temporizador = new Temporizador(int.Parse(this.txtIntervalo.Text));
            this.temporizador.NotificarTiempo += Actualizar;
            //Task tarea = Task.Run(this.temporizador.Correr);
            this.temporizador.NotificarActualizacionTiempo += Imprimir;
            this.temporizador.Correr();        
        }

        public void Actualizar()
        {
            MessageBox.Show("Se cumplio el tiempo");
        }
        int[] numeros = { 1, 2, 3, 5 };

        private void Imprimir(string mensaje)
        {
            if (this.lblTimer.InvokeRequired)
            {
                TimerDelegadoActualizarTimer delegado = Imprimir;
                object[] argumentos = { mensaje };
                this.BeginInvoke(delegado, argumentos);
            }
            else
            {
                this.lblTimer.Text = mensaje;
            }
        }

        private void FrmTimerApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
