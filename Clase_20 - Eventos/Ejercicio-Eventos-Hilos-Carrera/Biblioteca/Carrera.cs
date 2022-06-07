using System;
using System.Collections.Generic;
using System.Threading;

namespace Biblioteca
{
    public delegate void InformacionDeAvance();
    public delegate void InformacionLlegada(string mensaje);

    /// <summary>
    ///  clase encargada de simular la carrera.
    /// </summary>
    public class Carrera
    {
        public event InformacionDeAvance InformarAvance;
        public event Action<string> InformarLlegada;

        List<AutoF1> autos;
        int kms;

        public Carrera()
        {
            autos = new List<AutoF1>();
        }

        public Carrera(int kms) : this()
        {
            this.kms = kms;
        }

        public List<AutoF1> Autos { get => autos; set => autos = value; }
        public int Kms { get => kms; set => kms = value; }

        public void IniciarCarrera()
        {
            int cont = 1;
            foreach (AutoF1 item in autos)
            {
                item.Acelerar();
                if (this.InformarAvance is not null)
                    this.InformarAvance.Invoke();
                Thread.Sleep(10);
                cont++;
                if (item.UbicacionEnPista > this.Kms && item.Posicion == 0)
                {
                    item.Posicion = cont;
                    cont++;
                    if (this.InformarLlegada is not null)
                        this.InformarLlegada.Invoke(item.ToString());
                }
            }
        }
        public static Carrera operator +(Carrera c, AutoF1 a)
        {
            c.Autos.Add(a);
            return c;
        }
    }
}
