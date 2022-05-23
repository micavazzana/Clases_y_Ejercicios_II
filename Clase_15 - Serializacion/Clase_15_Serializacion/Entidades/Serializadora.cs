using System;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace Entidades
{
    public class Serializadora
    {
        private static string rutaBase;
        static Serializadora()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\ArchivosSerializados\\");
            Serializadora.rutaBase = info.FullName;
        }

        //SERIALIZAR XML
        public static void SerializarStreamWriter(string nombreArchivo, Persona persona)
        {
            //deberia hacerles try catch ya que me devuelven muchas excepciones
            using (StreamWriter sw = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer (typeof(Persona)); //el tipo de lo que voy a serializar
                xml.Serialize(sw, persona);
            }
        }
        public static void SerializarXmlTextWriter(string nombreArchivo, Persona persona)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Serializadora.rutaBase}{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                xmlTextWriter.Formatting = Formatting.Indented;//identar
                xml.Serialize(xmlTextWriter, persona);
            }
        }


        //DESERIALIZAR
        public static Persona DeserializarStreamReader(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona = xml.Deserialize(streamReader) as Persona;//"as" castea
                return persona;
            }
        }
        public static Persona DeserializarXmlTextReader(string nombreArchivo)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona = xml.Deserialize(xmlTextReader) as Persona;
                return persona;
            }
        }


        //USANDO UN JSON
        public static void SerializarJSON(string nombreArchivo, Empleado empleado)
        {
            using(StreamWriter sw = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true; //con esto lo idente
                string ser = JsonSerializer.Serialize(empleado, opciones);
                sw.WriteLine(ser);
            }
        }
        public static Empleado DesSerializarJSON(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                string json = streamReader.ReadToEnd();
                return JsonSerializer.Deserialize<Empleado>(json);
            }
        }
    }
}