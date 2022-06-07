using System;
using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        private static string rutaBase;

        static ArchivoTexto()
        {
            ArchivoTexto.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="contenidoAGuardar"></param>
        /// <exception cref="Exception"></exception>
        public static void Guardar(string ruta, string contenidoAGuardar)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{ArchivoTexto.rutaBase}\\{ruta}",true))
                {
                    streamWriter.WriteLine(contenidoAGuardar);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static string Leer(string ruta)
        {
            try
            {
                using(StreamReader streamReader = new StreamReader($"{ArchivoTexto.rutaBase}\\{ruta}"))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch(Exception)
            {
                throw new FileNotFoundException();
            }
        }
    }
}
