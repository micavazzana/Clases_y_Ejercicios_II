using System;
using System.Text;

namespace Biblioteca
{
    public class AutoF1
    {
        string escuderia;
        int posicion;
        int puntoPartida;
        int velocidad;

        public AutoF1()
        {
        }
        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.velocidad = velocidad;
            this.puntoPartida = puntoPartida;
        }

        public string Escuderia { get => escuderia; set => escuderia = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public int UbicacionEnPista { get => puntoPartida; set => puntoPartida = value; }

        public void Acelerar()
        {
            this.puntoPartida += this.Velocidad;
        }

        public override string ToString()
        {
            return $"Escuderia : {this.Escuderia}\nPosición del vehiculo : {this.Posicion}";
        }
    }
}
