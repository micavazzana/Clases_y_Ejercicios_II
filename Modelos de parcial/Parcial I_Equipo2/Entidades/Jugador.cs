using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class Jugador : Persona
    {
        public enum EPosicion
        {
            Arquero, Defensor, Central, Delantero
        }
        private float altura;
        private float peso;
        private EPosicion posicion;
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, EPosicion posicion)
           : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public EPosicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine($"Altura: {this.Altura}");
            sb.AppendLine($"Peso: {this.Peso}");
            sb.AppendLine($"Posicion: {this.Posicion}\n");
            return sb.ToString();
        }
        public bool ValidarEstadoFisico()
        {
            double imc = this.Peso / Math.Pow(this.Altura, 2);
            if (imc >= 18.5 && imc <= 25)
            {
                return true;
            }
            return false;
            
        }
        public override bool ValidarAptitud()
        {
            if(this.ValidarEstadoFisico() && this.Edad < 40)
            {
                return true;
            }
            return false;
        }

    }
}
