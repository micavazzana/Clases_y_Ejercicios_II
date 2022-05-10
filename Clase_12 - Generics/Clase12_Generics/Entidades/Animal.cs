using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        private string nombre;
        private string raza;
        private string especie;

        public Animal(string nombre, string raza, string especie)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.especie = especie;
        }

        public string Nombre { get { return nombre; } }
        public string Raza { get { return raza; } }
        public string Especie { get { return especie; } }

        public override string ToString()
        {
            return $"Soy un Animal \n Nombre:{this.Nombre} Especie: {this.Especie} Raza: {this.Raza}";
        }
    }
}
