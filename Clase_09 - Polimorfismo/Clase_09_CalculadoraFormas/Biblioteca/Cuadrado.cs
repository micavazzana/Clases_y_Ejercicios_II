using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Cuadrado : Rectangulo
    {
        public Cuadrado(double b, double a) : base(b, a)
        {

        }
        public override string Dibujar()
        {
            return "Dibujando cuadrado...";
        }
        
    }
}
