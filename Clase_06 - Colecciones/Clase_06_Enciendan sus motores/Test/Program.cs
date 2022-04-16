using System;
using Biblioteca;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(10, 5);
            AutoF1 a1 = new AutoF1(1, "Ferrari");
            AutoF1 a2 = new AutoF1(4, "Mercedes Benz");
            AutoF1 a3 = new AutoF1(5, "Mc Laren");
            AutoF1 a4 = new AutoF1(1, "Ferrari");
            AutoF1 a5 = new AutoF1(2, "Red Bull Racing");
            
            if (competencia + a1)
            {
                Console.WriteLine($"A1: \n{a1.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO A1 ****\n");
            }

            if (competencia + a2)
            {
                Console.WriteLine($"A2: \n{a2.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO A2 ****\n");
            }

            if (competencia + a3)
            {
                Console.WriteLine($"A3: \n{a3.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO A3 ****\n");
            }

            if (competencia + a4)
            {
                Console.WriteLine($"A4: \n{a4.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO A4 ****\n");
            }

            if (competencia + a5)
            {
                Console.WriteLine($"A5: \n{a5.MostrarDatos()}");
            }
            else
            {
                Console.WriteLine($"**** NO SE AGREGO A5 ****\n");
            }

            Console.WriteLine($"---------------------------------\nCOMPETENCIA: \n{competencia.MostrarDatos()}");

        }
    }
}
