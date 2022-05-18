using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        private List<string> tareas;

        public Empleado()
        {
            this.tareas = new List<string>();
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> Tareas { get => this.tareas; set => this.tareas = value; }

        public override string ToString()
        {
            string tareas = string.Empty;
            this.tareas.ForEach(m => tareas += " " + m);
            return $"{Nombre} {Apellido}";

        }
    }
}
