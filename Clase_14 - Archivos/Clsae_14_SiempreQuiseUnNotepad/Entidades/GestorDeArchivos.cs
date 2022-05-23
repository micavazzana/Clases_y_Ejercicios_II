using System;
using System.IO;

namespace Entidades
{
    public class GestorDeArchivos
    {
        static string rutaBase;
        public GestorDeArchivos()
        {
            GestorDeArchivos.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public bool Escribir(string ruta, string dato, bool append)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{ruta}"))
                {
                    sw.WriteLine(dato);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al escribir", ex);
            }
        }

        public string Leer(string ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{ruta}"))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer", ex);
            }
        }
    }
}