using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class GestorArchivoTexto : IArchivos<string>
    {
        static string rutaBase;
        public GestorArchivoTexto()
        {
            GestorArchivoTexto.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public bool Escribir(string ruta, string dato, bool append)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter($"{GestorArchivoTexto.rutaBase}\\{ruta}"))
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
                using (StreamReader sr = new StreamReader($"{GestorArchivoTexto.rutaBase}\\{ruta}"))
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
