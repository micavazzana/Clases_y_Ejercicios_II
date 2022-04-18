using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Perro : Animal
    {
        public Perro(string nombre, int edad) : base(nombre, edad)
        {
        }

        public override string EmitirSonido()
            //el override lo agrego para aclarar que lo estoy modificando de la clase base que estoy heredando
            //ESTO es Herencia Polimorfica
        {
            return "Guau";
        }
    }
}
