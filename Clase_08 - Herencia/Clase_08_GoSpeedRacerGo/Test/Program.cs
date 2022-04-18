using System;
using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia f1 = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            Competencia motocross = new Competencia(10, 5, Competencia.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(4, "Red Bull Racing", 2);
            AutoF1 a2 = new AutoF1(5, "Ferrari", 45);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);
            MotoCross m2 = new MotoCross(9, "Mc Laren", 32);
            VehiculoDeCarrera v = new VehiculoDeCarrera(6,"Mercedes Benz");

            if(f1 + a1)
            {
                Console.WriteLine($"Agregue A1 a competencia F1: \n{a1.MostrarDatos()}");
            }
            else 
            {
                Console.WriteLine($"******* No puede agregar A1 a competencia F1 *******\n");
            }
            
            if (f1 + a2)
            {
                Console.WriteLine($"Agregue A2 a competencia F1: \n{a2.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"******* No puede agregar A2 a competencia F1 *******\n");
            }

            if (f1 + m1)
            {
                Console.WriteLine($"Agregue M1 a competencia F1: \n{m1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"******* No puede agregar M1 a competencia F1 *******\n");
            }

            if (motocross + m1)
            {
                Console.WriteLine($"Agregue M1 a competencia MotoCross: \n{m1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"******* No puede agregar M1 a competencia MotoCross *******\n");
            }
            if (motocross + m2)
            {
                Console.WriteLine($"Agregue M2 a competencia MotoCross: \n{m1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"******* No puede agregar M2 a competencia MotoCross *******\n");
            }
            
            if (motocross + a2)
            {
                Console.WriteLine($"Agregue A2 a competencia MotoCross: \n{m1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"******* No puede agregar A2 a competencia MotoCross *******\n");
            }
            if (f1 + v)
            {
                Console.WriteLine($"Agregue VEHICULO a competencia F1: \n{a1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"******* No puede agregar VEHICULO a competencia F1 *******\n");
            }
            /*
            Console.WriteLine($"-------------------------------------\nCOMPETENCIA F1: \n{f1.MostrarDatos()}\n");
            Console.WriteLine($"-------------------------------------\nCOMPETENCIA MotoCross: \n{motocross.MostrarDatos()}\n");*/
        }
    }
}
