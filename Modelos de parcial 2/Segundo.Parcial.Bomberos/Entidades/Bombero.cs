using System;
using System.Collections.Generic;
using System.Threading;

namespace Entidades
{
    public class Bombero : IArchivo<string>,IArchivo<Bombero>
    {
        private string nombre;
        private List<Salida> salidas;

        public event FinDeSalida MarcarFin;

        public Bombero()
        {
            this.salidas = new List<Salida>();
        }
        public Bombero(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salida> Salidas { get => salidas; set => salidas = value; }

        public void Guardar(Bombero info)
        {
            try
            {
                Serializadora<Bombero>.SerializarXml("Bombero.xml", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar el archivo Bombero.xml", ex);
            }
        }

        public Bombero Leer()
        {
            Bombero b;
            try
            {
                b = Serializadora<Bombero>.DeserializarXml("Bombero.xml");
                return b;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar el archivo Bombero.xml", ex);
            }
        }

        void IArchivo<string>.Guardar(string info)
        {
            try
            {
                GestorSql.GuardarDatos(info);
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error con la base de datos", ex);
            }
        }

        string IArchivo<string>.Leer()
        {
            string cadena = String.Empty;
            try
            {
                cadena = GestorSql.LeerDatos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error con la base de datos", ex);
            }
            return cadena;
        }

        public void AtenderSalida(int bomberoIndex)
        {
            try
            {
                Salida nuevaSalida = new Salida();
                Random rand = new Random();
                this.salidas.Add(nuevaSalida);
                
                Thread.Sleep(rand.Next(2000, 4000));
                
                nuevaSalida.FinalizarSalida();
                
                string datosSalida =
                    $"Inicio: {nuevaSalida.FechaInicio} - " +
                    $"Fin: {nuevaSalida.FechaFin}\n" +
                    $"Duracion total: {nuevaSalida.TiempoTotal} segundos";
                GestorSql.GuardarDatos(datosSalida);
                
                if (this.MarcarFin != null)
                    this.MarcarFin.Invoke(bomberoIndex);
            }
            catch(Exception ex)
            {
                throw new Exception("Error al atender salida", ex);
            }
        }
    }
}
