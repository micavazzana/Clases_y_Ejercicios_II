using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void TimerDelegado();
    public delegate void TimerDelegadoActualizarTimer(string tiempoRestante);
    public class Temporizador
    {
        public event TimerDelegado NotificarTiempo;
        public event TimerDelegadoActualizarTimer NotificarActualizacionTiempo;

        private int intervalo;
        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo * 1000;
        }

        public void Correr()
        {
            Task.Run(() =>
            {
                int contador = intervalo;
                while (contador > 0)
                {
                    contador -= 1000;
                    Thread.Sleep(1000);
                    if (this.NotificarActualizacionTiempo is not null)
                        this.NotificarActualizacionTiempo.Invoke($"Quedan {contador/1000} segundos");
                }
                if (this.NotificarTiempo is not null)
                    this.NotificarTiempo.Invoke();
            });
        }

        
    }
}


