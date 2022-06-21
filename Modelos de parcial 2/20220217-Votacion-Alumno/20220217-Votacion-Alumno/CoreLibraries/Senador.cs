using System;
using System.Drawing;

namespace CoreLibraries
{
    public class Senador :IParlamentario
    {
        private string banca;
        private object controlVisual;
        private bool presentismo;
        private EVoto voto;

        public Senador(string banca, object controlVisual)
        {
            this.banca = banca;
            this.controlVisual = controlVisual;
            this.voto = EVoto.Indefinido;
        }

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual { get => controlVisual; set => controlVisual = value; }

        public string Banca 
        { 
            get => banca; 
            set => banca = value; 
        }

        public Color ColorDeBanca
        {
            get
            {
                if (this.Presentismo)
                {
                    switch (this.voto)
                    {
                        case EVoto.Abstencion:
                            return Color.FromArgb(0,200,255);
                        case EVoto.Negativo:
                            return Color.DarkRed;
                        case EVoto.Positivo:
                            return Color.DarkGreen;
                        default:
                            return Color.DarkBlue;
                    }
                }
                else
                    return Color.Black;
            }
        }

        public bool AperturaSesion
        {
            set
            {
               
                if (value)
                {
                    Random random = new Random();
                    if (random.Next(0,2) == 1)
                    {
                        this.Presentismo = value;
                    }
                    else
                    {
                        this.Presentismo = false;
                    }
                }
                else
                {
                    this.Presentismo = false;
                }
            }
        }

        public bool Presentismo 
        { 
            get => this.presentismo; 
            set => this.presentismo = value; 
        }
        public EVoto Voto 
        { 
            get => this.voto; 
            set => this.voto = value; 
        }

        public void EmitirVoto()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1 ,4);
            this.voto = (EVoto)numeroAleatorio;
        }
    }
}
