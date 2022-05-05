using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TesteoFizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_CuandoSeaDivisiblePorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numeroDivisiblePorTres = 3;
            string expected = "Fizz";
            string actual;
            //Act
            actual = numeroDivisiblePorTres.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FizzBuzz_CuandoSeaDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int numeroDivisiblePorCinco = 5;
            string expected = "Buzz";
            string actual;
            //Act
            actual = numeroDivisiblePorCinco.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoSeaDivisiblePorTresYPorCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numeroDivisiblePorTresYPorCinco = 15;
            string expected = "FizzBuzz";
            string actual;
            //Act
            actual = numeroDivisiblePorTresYPorCinco.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(2,"2")]
        [DataRow(4, "4")]
        [DataRow(22, "22")]
        [DataRow(23, "23")]
        public void FizzBuzz_CuandoSeaNoEsDivisiblePorTresOPorCinco_DeberiaRetornarNumero(int n, string expected)
        {
            //Arrange
            //Parametrizado
            string actual;
            //Act
            actual = n.FizzBuzz();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
