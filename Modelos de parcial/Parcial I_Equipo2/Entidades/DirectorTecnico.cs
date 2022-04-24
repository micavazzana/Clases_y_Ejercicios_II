using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int aniosExperiencia;
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int aniosExperiencia)
            : base(nombre, apellido, edad, dni)
        {
            this.AniosExperiencia = aniosExperiencia;
        }

        public int AniosExperiencia
        {
            get
            {
                return this.aniosExperiencia;
            }

            set
            {
                this.aniosExperiencia = value;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Años de experiencia: {this.AniosExperiencia}");
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if (this.AniosExperiencia >= 2 && this.Edad <= 65)
            {
                return true;
            }
            return false;
        }
    }
}
