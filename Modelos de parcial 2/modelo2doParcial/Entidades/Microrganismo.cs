using System;

namespace Entidades
{
    public enum Econtagiosidad
    {
        Baja, Moderada, Alta
    }
    public enum Etipo
    {
        Virus, Bacteria
    }
    public abstract class Microrganismo
    {
        protected long contador;
        private Econtagiosidad contagiosidad;
        private string nombre;
        private Etipo tipo;

        public Microrganismo(string nombre)
        {
            this.contador = 1;
            this.nombre = nombre;
        }
        public Microrganismo(string nombre, Etipo tipo, Econtagiosidad contagiosidad)
            : this (nombre)
        {
            this.tipo = tipo;
            this.contagiosidad = contagiosidad;
        }
        public abstract long IndiceDeContagios { get; }

        public string Informe()
        {
            return $"{this.tipo} lleva el nombre de {this.nombre} y tiene una contagiosidad {this.contagiosidad}." +
                $"Su impacto de contagios se calcula en {this.IndiceDeContagios}";
        }
    }
}
