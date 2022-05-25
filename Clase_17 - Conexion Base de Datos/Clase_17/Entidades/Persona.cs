using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string sexo;
        private int edad;
        private string mail;

        public Persona(string nombre, string apellido, string mail, string sexo, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.edad = edad;
            this.mail = mail;
        }
        public Persona(int id, string nombre, string apellido, string mail, string sexo, int edad)
            :this(nombre,apellido,mail,sexo,edad)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Mail { get => mail; set => mail = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Id:{this.id}");
            sb.AppendLine($"Nombre:{this.nombre}");
            sb.AppendLine($"Apellido:{this.apellido}");
            sb.AppendLine($"Mail:{this.mail}");
            sb.AppendLine($"Sexo:{this.sexo}");
            sb.AppendLine($"Edad:{this.edad}");
            return sb.ToString();
        }
    }
}
