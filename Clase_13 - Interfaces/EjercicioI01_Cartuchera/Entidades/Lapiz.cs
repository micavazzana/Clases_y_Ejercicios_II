using System;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }
        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }

        ///REVISAR
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            if (((IAcciones)this).UnidadesDeEscritura >= texto.Length)
            {
                foreach (char c in texto)
                {
                    ((IAcciones)this).UnidadesDeEscritura -= 0.1f;
                }
                return new EscrituraWrapper(texto, ((IAcciones)this).Color);
            }
            return null;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Soy un Lápiz, mi nivel de tinta es:{Math.Round(((IAcciones)this).UnidadesDeEscritura, 2)} y mi color: {((IAcciones)this).Color}";
        }
    }
}
