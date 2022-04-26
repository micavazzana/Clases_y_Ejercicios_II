using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Enemigo : Personaje
    {
        private string objetivo;

        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo)
            :base(nombre, hab)
        {
            this.objetivo = objetivo;
        }
        protected override string Nombre
        {
            get 
            { 
                return $"Soy {this.nombre} y los voy a hacer puré";
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Objetivo: {this.objetivo}");
            return sb.ToString();
        }

    }
}
