using System;
using Entidades;
using IO;

namespace EjercicioI01_Lanzar_y_atrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;
            DateTime date = DateTime.Now;
            string nombreArchivo = $"{date.ToString("yyyy")}{date.ToString("MM")}{date.ToString("dd")}-" +
               $"{date.ToString("hh")}{date.ToString("mm")}.txt";

            try
            {
               otraClase = new OtraClase();
               otraClase.MetodoOtraClase();
            }
            catch (MiExcepcion ex)
            {
                ArchivoTexto.Guardar(nombreArchivo, $"{ex.Message}\n{ex.InnerException}");
            }
            try
            {
                Console.WriteLine(ArchivoTexto.Leer(nombreArchivo));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
