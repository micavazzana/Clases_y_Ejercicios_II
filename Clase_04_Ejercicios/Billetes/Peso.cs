using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }
        public static explicit operator Dolar(Peso p)
        {
            Dolar dolar = new Dolar(p.GetCantidad() / Peso.GetCotizacion());
            return dolar;
        }
        public static explicit operator Euro(Peso p)
        {
            return new Euro(((Dolar)p).GetCantidad() / Euro.GetCotizacion());//no estoy segura
        }
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        ///
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == ((Peso)d).GetCantidad();
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(d == p);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == ((Peso)e).GetCantidad();
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(e == p);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() - ((Peso)d).GetCantidad());
        }
    }
}
