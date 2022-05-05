using System;
using Entidades;

namespace EjercicioI01_Lanzar_y_atrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;
            try 
            {
               otraClase = new OtraClase();
               otraClase.MetodoOtraClase();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);//muestra el path
            }           
        }
    }
}
