using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private long dni;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        public Persona(string nombre, long dni)
            :this(nombre)
        {
            this.dni = dni;
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public long Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dni: {Dni}");
            return sb.ToString();
        }
    }
}
