using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Alumno)), XmlInclude(typeof(Profesor)), XmlInclude(typeof(Jefe<Empleado>))]
    public class Persona
    {
        protected string nombre;
        protected int edad;

        public Persona()
        {

        }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public virtual string Nombre { get => this.nombre; set => this.nombre = value; }
        public virtual int Edad { get => this.edad; set => this.edad = value; }
    }
}

