using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringTest
{
    [TestClass]
    public class ContarPalabrasTest
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibaDosPalabras_DeberiaRetornarNumero2()
        {
            //Arrange: Area de preparacion
            string str = "Hola mundo";
            int expected = 2;
            int actual;

            //Act: Invocacion de metodos a probar
            actual = str.ContarPalabras();

            //Assert: Evalua los resultados
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarPalabras_CuandoRecibaDosPalabrasSeparadasPorGuion_DeberiaRetornarNumero2()
        {
            //Arrange: Area de preparacion
            string str = "Hola-mundo";
            int expected = 2;
            int actual;

            //Act: Invocacion de metodos a probar
            actual = str.ContarPalabras();

            //Assert: Evalua los resultados
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContarPalabras_CuandoRecibaStringVacio_DeberiaLanzarArgumentException()
        {
            string str = String.Empty;

            int actual = str.ContarPalabras();
        }
    }
}
