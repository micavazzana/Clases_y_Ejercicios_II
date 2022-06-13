using System;
using System.Threading.Tasks;
using Clase;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new Reloj();
            reloj.OnNotificarCambio += ImprimirHora;//Suscribo el metodo.
                                                    //Va a imprimir si el metodo "iniciar" lanza el evento 
            
           
            reloj.Iniciar();

            reloj.OnNotificarCambio += ImprimirHora2;



            Console.ReadKey();
        }

        //METODO MANEJADOR: debe coincidir la firma con la del delegado:
        public static void ImprimirHora(Reloj reloj)
        {
            Console.Clear();
            Console.WriteLine($"{reloj.Hora}:{reloj.Minutos}:{reloj.Segundos}");
        }
        public static void ImprimirHora2(Reloj reloj)
        {
            Console.WriteLine("zareasa");
        }
    }
}
