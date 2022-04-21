using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Circulo : Figura
    {
        private double diametro;

        public Circulo(double diametro)
        {
            this.diametro = diametro;

        }
        public override string Dibujar()
        {
            return "Dibujando circulo...";
        }
        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.diametro / 2, 2); ;
        }
        public override double CalcularPerimetro()
        {
            return this.diametro * Math.PI;
        }
    }
}
