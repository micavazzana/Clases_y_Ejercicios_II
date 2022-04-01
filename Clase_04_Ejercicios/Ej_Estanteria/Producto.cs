using System;

namespace Ej_Estanteria
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            return $"Marca: {p.GetMarca()} Codigo de barras: {p.codigoDeBarra} Precio: {p.GetPrecio()}";
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(!(p1 is null || p2 is null))
                return (p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra);
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p, string marca)
        {
            return p.GetMarca() == marca;
        }
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
