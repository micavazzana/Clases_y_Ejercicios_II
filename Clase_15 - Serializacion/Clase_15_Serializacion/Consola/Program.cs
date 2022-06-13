using System;
using Entidades;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona alumno = new Alumno("Don gato", 23, 5);
            Persona profesor = new Profesor("Benito", 45, "ASD123");
            ((Alumno)alumno).Materias.Add("Programacion");
            ((Alumno)alumno).Materias.Add("Laboratorio");
            Jefe<Empleado> jefe = new Jefe<Empleado>();

            Serializadora.SerializarXmlTextWriter("jefe", jefe);
            /*Serializadora.SerializarXmlTextWriter("profesorSerializadoXMLProfesor.xml", profesor);
            Serializadora.SerializarStreamWriter("alumnoSerializadoStreamWriter.xml", alumno);

            Persona a = Serializadora.DeserializarStreamReader("alumnoSerializadoStreamWriter.xml");
            Console.WriteLine(a.ToString());
            
            Console.WriteLine("\n/****JSON:***//*\n");
            //JSON
            Empleado empleado = new Empleado();
            empleado.Nombre = "Pepe";
            empleado.Apellido = "Perez";
            empleado.Tareas.Add("Cocinar");
            empleado.Tareas.Add("Limpiar");
            Serializadora.SerializarJSON("persona.json",empleado);

            Empleado e = Serializadora.DesSerializarJSON("persona.json");
            Console.WriteLine(e.ToString());*/
        }
    }
}
 