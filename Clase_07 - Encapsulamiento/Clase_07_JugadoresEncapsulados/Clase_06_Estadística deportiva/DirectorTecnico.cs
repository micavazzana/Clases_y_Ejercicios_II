using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        private DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            :this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento.ToString("dd/MM/yyyy")}");
            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return dt1.Dni == dt2.Dni && dt1.fechaNacimiento == dt2.fechaNacimiento;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
