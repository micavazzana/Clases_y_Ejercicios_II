using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona alumno = new Alumno("Don gato", 23, 5);
            Persona profesor = new Profesor("Benito", 45, "ASD123");

            //Serializadora.SerializarXmlTextWriter("profeSerializadoXMLProfesor.xml", profesor);
            Serializadora.SerializarStreamWriter("alumnoSerializadoStreamWriter.xml", alumno);

            Persona a = Serializadora.DeserializarStreamReader("alumnoSerializadoStreamWriter.xml");
        }
    }
}
