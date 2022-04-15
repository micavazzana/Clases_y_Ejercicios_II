using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if (tinta >= 0 && tinta <= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar()
        {
            SetTinta(Boligrafo.cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            int cantTintaPostPintura;
            StringBuilder sb = new StringBuilder();

            dibujo = " ";            
            if(GetTinta() > 0 && gasto >=0 && gasto <= Boligrafo.cantidadTintaMaxima)
            {
                cantTintaPostPintura = GetTinta() - gasto;
                if (cantTintaPostPintura < 0)
                {
                    for (int i = 0; i < GetTinta(); i++)
                    {
                        sb.Append("*");
                    }
                    SetTinta(0);
                }
                else
                {
                    SetTinta((short)cantTintaPostPintura);
                    for (int i = 0; i < gasto; i++)
                    {
                        sb.Append("*");
                    }
                }
                dibujo = sb.ToString();
            }
            return true;
        }
    }
}
