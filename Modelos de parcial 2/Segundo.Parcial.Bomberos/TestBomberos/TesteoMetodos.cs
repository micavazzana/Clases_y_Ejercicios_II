using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;

namespace TestBomberos
{
    [TestClass]
    public class TesteoMetodos
    {
        [TestMethod]
        public void SerializarXmlYDeserializarXml_CuandoSerializoYDeserializoObjetos_LosObjetosDeberianSerIguales()
        {
            Bombero b = new Bombero("Perez");
            Serializadora<Bombero>.SerializarXml("TestSerializacion.xml", b);
            Bombero bLeido = Serializadora<Bombero>.DeserializarXml("TestSerializacion.xml");

            Assert.AreEqual(b.Nombre, bLeido.Nombre);            
        }
       
        [TestMethod]
        public void CalcularDiferenciaSegundos_CuandoBuscaLaDiferenciaDeSegundos_DeberiaDevolverLaDiferenciaDeSegundos()
        {
            DateTime timeFin = DateTime.Now.AddSeconds(50);
            DateTime timeInicio = DateTime.Now;
            double expected = 50;
            
            double resultado = timeFin.CalcularDiferenciaSegundos(timeInicio);

            Assert.AreEqual(expected, Math.Round(resultado));
        }
    }
}
