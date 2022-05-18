using System;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }
        public ConsoleColor Color
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }
        public float UnidadesDeEscritura
        {
            get { return this.tinta; }
            set { this.tinta = value; }
        }

        //REVISAR
        public EscrituraWrapper Escribir(string texto)
        {
            if (this.UnidadesDeEscritura >= texto.Length)
            {
                foreach (char c in texto)
                {
                    this.UnidadesDeEscritura -= 0.3f;
                }
                return new EscrituraWrapper(texto, this.Color);
            }
            return null;
        }
        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Soy un Bolígrafo, mi nivel de tinta es: {Math.Round(this.UnidadesDeEscritura, 2)} y mi color: {this.Color}";
        }
    }
}
