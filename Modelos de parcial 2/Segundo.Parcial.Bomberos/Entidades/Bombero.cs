using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero : IArchivo<string>, IArchivo<Bombero>
    {
        private string nombre;
        private List<Salida> salidas;
        public event FinDeSalida MarcarFin;
        private static string rutaBase;
        private static Random random;

        static Bombero()
        {
            Bombero.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            random = new Random();
        }
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
        public void AtenderSalida(int bomberoIndex)
        {
            Salida nuevaSalida = new Salida();
            this.salidas.Add(nuevaSalida);
            Thread.Sleep(random.Next(2000,4000));
            nuevaSalida.FinalizarSalida();
            //Registrará la salida (horario de inicio, horario de fin y duración total)
            //en la tabla log de la base de datos.
            MarcarFin(bomberoIndex);
        }

        //Implementacion implicita. Bombero guarda en xml
        public void Guardar(Bombero info)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{rutaBase}\\Bombero.xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Bombero));
                    xml.Serialize(sw, info);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error al serializar bombero",ex);
            } 
        }
        public Bombero Leer()
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{rutaBase}\\Bombero.xml"))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Bombero));
                    Bombero bombero = xml.Deserialize(sr) as Bombero;
                    return bombero;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar bombero", ex);
            }
        }

        //Implementacion explicita
        void IArchivo<string>.Guardar(string info)
        {
            throw new NotImplementedException();
        }
        string IArchivo<string>.Leer()
        {
            throw new NotImplementedException();
        }
    }
}
