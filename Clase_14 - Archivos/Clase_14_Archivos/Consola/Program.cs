using System;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESCRIBO, de no existir crea el archivo
            GestorDeArchivo.Escribir2("miPrimerArchivo.txt", "Hola mundo");

            //lo leo y muestro por consola
            Console.WriteLine($"Contenido archivo:\n{GestorDeArchivo.Leer("miPrimerArchivo.txt")}");

            /******************************************************************************************/
            
            //Clase de Gestor de archivo que implementa la interfaz
            GestorArchivoTexto gda = new GestorArchivoTexto();

            try
            {
                gda.Escribir("miArchivoTexto.text", "Saludos", true);
                Console.WriteLine($"{gda.Leer("miArchivoTexto.txt")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
