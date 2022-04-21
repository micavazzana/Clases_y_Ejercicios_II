using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo : Figura
    {
        private double _base;
        private double altura;

        public Rectangulo(double _base, double altura)
        {
            this._base = _base;
            this.altura = altura;
        }
        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }

        public override double CalcularSuperficie()
        {
            return this._base * this.altura;
        }

        public override double CalcularPerimetro()
        {
            return (this._base + this.altura)*2;
        }
    }
}
