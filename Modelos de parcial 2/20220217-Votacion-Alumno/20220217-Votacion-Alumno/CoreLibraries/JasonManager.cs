using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public static class JasonManager<T> where T : class, new()
    {
        private static string file;

        static JasonManager()
        {
            file = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\votacion.json";
        }
        public static void Guardar(string fileName, T elemento)
        {
            file = fileName;
            Guardar(elemento);
        }
        public static void Guardar(T elemento)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(elemento, opciones);
                    sw.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {
                throw new FilesException("Error al serializar el json", ex);
            }
        }       
    }
}
