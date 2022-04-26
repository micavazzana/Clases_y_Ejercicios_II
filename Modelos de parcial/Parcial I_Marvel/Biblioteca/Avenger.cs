using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Avenger : Personaje
    {
        private EEquipamiento equipamiento;
        
        public Avenger(string nombre, List<EHabilidades> hab, EEquipamiento equipo)
            :base(nombre, hab)
        {
            this.equipamiento = equipo;
        }

        protected override string Nombre
        {
            get
            {
                return $"Mi nombre es {this.nombre} y si no puedo y si no puedo proteger la tierra, la vengaré";
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Equipamiento: {this.equipamiento}");
            return sb.ToString();
        }
    }
}
