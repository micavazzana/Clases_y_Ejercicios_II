using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Entidades
{
    public class Serializadora<T>
    {
        private static string rutaBase;

        static Serializadora()
        {
            //rutaBase = $"{AppDomain.CurrentDomain.BaseDirectory}\\Archivos";
            rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        public static void SerializarXml(string nombreArchivo, T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{rutaBase}\\{nombreArchivo}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    xml.Serialize(sw, objeto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el xml", ex);
            }
        }

        public static void SerializarJson(string nombreArchivo, T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{rutaBase}\\{nombreArchivo}"))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(objeto, opciones);
                    sw.WriteLine(ser);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el json", ex);
            }
        }

        public static T DeserializarXml(string nombreArchivo)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader($"{rutaBase}\\{nombreArchivo}"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(T));
                    T tipo = (T)xml.Deserialize(streamReader);
                    return tipo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar xml", ex);
            }
        }

        public static T DeserializarJson(string nombreArchivo)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader($"{rutaBase}\\{nombreArchivo}"))
                {
                    string json = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<T>(json);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar json", ex);
            }
        }
    }
}