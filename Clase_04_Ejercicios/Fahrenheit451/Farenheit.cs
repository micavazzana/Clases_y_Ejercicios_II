using System;

namespace Fahrenheit451
{
    public class Farenheit
    {
        private double gradosFarenheit;

        public Farenheit(double grados)
        {
            this.gradosFarenheit = grados;
        }
        public double GetGrados()
        {
            return this.gradosFarenheit;
        }

        //Sobrecargas operadores explicit/implicit
        public static explicit operator Kelvin(Farenheit grados)
        {
            return new Kelvin((grados.GetGrados() + 459.67) * 5 / 9);
        }
        public static explicit operator Celsius(Farenheit grados)
        {
            return new Celsius((grados.GetGrados() - 32) * 5 / 9);
        }
        public static implicit operator Farenheit(double grados)
        {
            return new Farenheit(grados);
        }
    }
}
