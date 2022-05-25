using System;
using System.Collections.Generic;
using Entidades;

namespace VistaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* List<Persona> personas = GestorSQL.LeerDatos();
                 foreach (Persona persona in personas)
                 {
                     Console.WriteLine(persona.ToString());
                 }*/
                Persona nuevaPersona = new Persona("Micaela", "Vazzana", "mica.vazzana@gmail.com", "female", 32);
                // GestorSQL.Alta(nuevaPersona);
                // GestorSQL.Borrar(1);

                //Modifico
                GestorSQL.Actualizar(nuevaPersona, 2);
                Persona p = GestorSQL.LeerDatosPorId(2);
                Console.WriteLine(p.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
