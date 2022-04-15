using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit451
{
    public class Celsius
    {
        private double gradosCelsius;

        public Celsius(double grados)
        {
            this.gradosCelsius = grados;
        }
        public double GetGrados()
        {
            return this.gradosCelsius;
        }

        //Sobrecargas operadores explicit/implicit
        public static explicit operator Kelvin(Celsius grados)
        {
            return new Kelvin((((Fahrenheit)grados).GetGrados() + 459.67) * 5 / 9);
        }
        public static explicit operator Fahrenheit(Celsius grados)
        {
            return new Fahrenheit((grados.GetGrados() * 9/5) + 32);
        }
        public static implicit operator Celsius(double grados)
        {
            return new Celsius(grados);
        }
    }
}
