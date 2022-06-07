using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jefe<T> : Persona
    {
        public Jefe() : base()
        {

        }
        public Jefe(string nombre, int edad) : base(nombre, edad)
        {

        }
    }
}
