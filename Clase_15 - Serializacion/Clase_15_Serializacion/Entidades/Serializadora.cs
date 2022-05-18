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

        public static void SerializarStreamWriter(string nombreArchivo, Persona persona)
        {
            //deberia hacerles try catch ya que me devuelven muchas excepciones
            using (StreamWriter sw = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer (typeof(Persona)); //el tipo de lo que voy a serializar
                xml.Serialize(sw, persona);
            }
        }

        //
        public static void SerializarXmlTextWriter(string nombreArchivo, Persona persona)
        {
            using (XmlTextWriter stream = new XmlTextWriter($"{Serializadora.rutaBase}{nombreArchivo}", Encoding.UTF8))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                stream.Formatting = Formatting.Indented;
                xml.Serialize(stream, persona);
            }
        }


        public static Persona DeserializarStreamReader(string nombreArchivo)
        {
            using (StreamReader streamReader = new StreamReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona = xml.Deserialize(streamReader) as Persona;
                return persona;
            }
        }

        //
        public static Persona DeserializarXmlTextReader(string nombreArchivo)
        {
            using (XmlTextReader xmlTextReader = new XmlTextReader($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona = xml.Deserialize(xmlTextReader) as Persona;  
                return persona;
            }
        }

        public static void SerializarJSON(string nombreArchivo, Empleado empleado)
        {
            using(StreamWriter sw = new StreamWriter($"{Serializadora.rutaBase}{nombreArchivo}"))
            {
                
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                string ser = JsonSerializer.Serialize(empleado, opciones);
                sw.WriteLine(ser);
            }
            //JsonSerializer.Deserialize
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