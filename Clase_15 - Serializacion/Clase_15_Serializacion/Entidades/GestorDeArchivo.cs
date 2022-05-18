using System;
using System.IO;

namespace Entidades
{
    public static class GestorDeArchivo
    {
        static string rutaBase;
        static GestorDeArchivo()
        {
            GestorDeArchivo.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public static bool Escribir(string ruta, string contenido, bool append)
        {
            StreamWriter sw = null;
            try
            {
                string nuevaRuta = $"{GestorDeArchivo.rutaBase}\\{ruta}";
                sw = new StreamWriter(nuevaRuta, append);
                sw.Write(contenido);

            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al escribir", ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
            return true;
        }
        public static bool Escribir(string ruta, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{GestorDeArchivo.rutaBase}\\{ruta}"))
                {
                    sw.WriteLine(contenido);

                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al escribir", ex);
            }
            return true;
        }

        public static string Leer(string ruta)
        {
            string retorno = String.Empty;
            try
            {
                using (StreamReader sw = new StreamReader($"{GestorDeArchivo.rutaBase}\\{ruta}"))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine(sw.ReadLine());
                    }

                    retorno = "";
                }

            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer una archivo", ex);
            }
            return retorno;
        }
    }
}
