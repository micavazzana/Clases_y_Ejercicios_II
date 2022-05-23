using System;
using Entidades;

namespace EjercicioC02_SeguiParticipando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia<VehiculoDeCarrera> f1 = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);
            Competencia<VehiculoDeCarrera> motocross = new Competencia<VehiculoDeCarrera>(10, 5, Competencia<VehiculoDeCarrera>.TipoCompetencia.MotoCross);
            AutoF1 a1 = new AutoF1(4, "Red Bull Racing", 2);
            AutoF1 a2 = new AutoF1(5, "Ferrari", 45);
            MotoCross m1 = new MotoCross(7, "Red Bull Racing", 34);
            MotoCross m2 = new MotoCross(9, "Mc Laren", 32);
            //VehiculoDeCarrera v = new VehiculoDeCarrera(6, "Mercedes Benz");

            try
            {
                if (f1 + a1)
                {
                    Console.WriteLine($"Agregue A1 a competencia F1: \n{a1.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                if (f1 + a2)
                {
                    Console.WriteLine($"Agregue A2 a competencia F1: \n{a2.MostrarDatos()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                if (motocross + m1)
                {
                    Console.WriteLine($"Agregue M1 a competencia MotoCross: \n{m1.MostrarDatos()}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                if (motocross + m2)
                {
                    Console.WriteLine($"Agregue M2 a competencia MotoCross: \n{m2.MostrarDatos()}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            try
            {
                if (f1 + m1)
                {
                    Console.WriteLine($"Agregue M1 a competencia F1: \n{m1.MostrarDatos()}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.WriteLine($"-------------------------------------\nCOMPETENCIA F1: \n{f1.MostrarDatos()}\n");
            Console.WriteLine($"-------------------------------------\nCOMPETENCIA MotoCross: \n{motocross.MostrarDatos()}\n");
        }
    }
}
