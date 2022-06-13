using System;
using System.Threading;
using System.Threading.Tasks;

namespace Clase
{
    //Un evento es un mensaje que emite una clase u objeto cuando ocurre algo dentro del objeto.
    //Es la manera en la que una clase notifica a otras clases cuando ocurre una accion
    //Es producida por una accion realizada por un usuario, como por ejemplo hacer un click en un boton
    //o puede ser producida por el cambio en el estado de un objeto
    public delegate void NotificarCambioHandler(Reloj sender);

    //un sender sera el objeto que genera el evento, es el emisor del mensaje. El receptor recibe y determina que hacer
    //Un handler sera un manejador y sera lo que va a estar entre el sender y el receptor del mensaje
    //El codigo que maneja el evento se lo conoce como metodo manejador (suscriptor)

    public class Reloj
    {
        private int hora;
        private int minutos;
        private int segundos;

        public int Hora { get => hora; set => hora = value; }
        public int Minutos { get => minutos; set => minutos = value; }
        public int Segundos { get => segundos; set => segundos = value; }

        public event NotificarCambioHandler OnNotificarCambio;
        //Un evento es de tipo delegado. El delegado es el handler.
        //La firma del metodo manejador tiene que coincidir con la firma del delegado
        //El evento suele ser miembro de la clase que lo genera
        public void Iniciar()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;
                    Thread.Sleep(100);
                    if (dt.Second != this.segundos)
                    {
                        if (this.OnNotificarCambio != null)//Chequear siempre que no sea null,
                                                           //si es null es pq no tiene suscriptores
                                                           //En vez de hacer el if puedo: this.OnNotificarCambio?.Invoke(this);
                                                           //Eso ya pregunta si es null o no
                            this.OnNotificarCambio.Invoke(this);
                        //Se le pasa la instancia que genera el evento
                        //en ese caso es esta misma clase, por la firma del delegado
                    }
                    hora = dt.Hour;
                    minutos = dt.Minute;
                    segundos = dt.Second;
                }
            });
        }
        //EventArgs es la clase base para todos los datos de eventos. 

    }
}
