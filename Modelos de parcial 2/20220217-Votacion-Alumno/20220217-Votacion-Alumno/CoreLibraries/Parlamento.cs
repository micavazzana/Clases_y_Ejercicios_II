using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public class Parlamento<T>
        where T: IParlamentario
    {
        public delegate void InformaCambioEstado(T obj);

        public event FinalizarRegistro FinVotacion;
        public event FinalizarRegistro ParlamentariosRegistrados;
        public event InformaCambioEstado OcupaBanca;
        public event InformaCambioEstado VotoEmitido;

        CancellationTokenSource cancelacion;
        private List<T> bancas;
        private bool estadoSesion;
        private T presidente;

        public Parlamento()
        { }
        public Parlamento(T presidente)
        {
            this.presidente = presidente;
            this.cancelacion = new CancellationTokenSource();
            this.bancas = new List<T>();
        }

        public List<T> Bancas { get => bancas; set => bancas = value; }
        public bool EstadoSesion 
        {
            set
            {
                this.estadoSesion = value;
                Task.Run(() =>
                {
                    foreach(T item in bancas)
                    {
                        item.AperturaSesion = this.estadoSesion;
                        if(this.OcupaBanca is not null)
                            this.OcupaBanca(item);
                        Thread.Sleep(50);
                        if(this.ParlamentariosRegistrados is not null)
                            this.ParlamentariosRegistrados.Invoke();
                    }
                });
            }
        }
        public T Presidente { get => presidente; }
        public int VotosAbstenciones
        {
            get
            {
                return ContarVotos(EVoto.Abstencion);
            }
        }
        public int VotosAfirmativos
        {
            get
            {
                return ContarVotos(EVoto.Positivo);
            }
        }
        public int VotosNegativos
        {
            get
            {
                return ContarVotos(EVoto.Negativo);
            }
        }
        private int ContarVotos(EVoto voto)
        {
            int contar = 0;
            foreach (T item in bancas)
            {
                if (item.Voto == voto)
                {
                    contar++;
                }
            }
            return contar;
        }
        public void CancelarVotacion()
        {
            cancelacion.Cancel();
        }
        public void DesempatePresidente()
        {
            if(VotosAfirmativos == VotosNegativos)
            {
                presidente.EmitirVoto();
                if(this.VotoEmitido is not null)
                    this.VotoEmitido.Invoke(presidente);
            }
            else
            {
                throw new NoNecesitaDesempateException();
            }
        }

        public void IniciarVotacion()
        {
            Random random = new Random();
            Task.Run(() =>
            {
                foreach(T item in bancas)
                {
                    if(item.Presentismo)
                    {
                        item.EmitirVoto();
                        if (this.VotoEmitido is not null)
                            this.VotoEmitido.Invoke(item);
                        Thread.Sleep(random.Next(400,1000));
                    }
                }
                try
                {
                    DesempatePresidente();
                }
                catch(Exception ex)
                {

                }
                if (this.FinVotacion is not null)
                    this.FinVotacion.Invoke();
                JasonManager<Parlamento<T>>.Guardar(this);
            },cancelacion.Token);
        }
    }
}
