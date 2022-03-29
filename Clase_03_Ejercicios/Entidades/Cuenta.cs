using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string razonSocial, decimal dineroEnCuenta)
        {
            this.titular = razonSocial;
            this.cantidad = dineroEnCuenta;
        }

        private string GetRazonSocial()
        {
            return this.titular;
        }

        private decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"Titular: {this.GetRazonSocial()} \n Dinero en cuenta: {this.GetCantidad()}";
        }

        public void Ingresar(decimal montoAcreditar)
        {
            if (montoAcreditar > 0)
            {
                this.cantidad += montoAcreditar;
            }
        }

        public void Retirar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad -= monto;
            }
        }
    }
}
