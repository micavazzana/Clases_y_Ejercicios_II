using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioI01_TestDrivenDevelopment;

namespace TestAdd
{
    [TestClass]
    public class TestAdd
    {
        /// <summary>
        /// Testea el metodo Add cuando recibe un string vacio
        /// Devuelve 0
        /// </summary>
        [TestMethod]
        public void Add_CuandoRecibeStringVacio_DeberiaDevolverCero()
        {
            //Arrange
            string numeros = "";
            int expected = 0;
            int actual;
            //Act
            actual = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testea el metodo Add cuando se pasa un string con numeros separados por comas
        /// Devuelve la suma de esos numeros
        /// </summary>
        [TestMethod]
        public void Add_CuandoRecibeNumerosSeparadosPorComas_DeberiaDevolverLaSumaDeLosNumeros()
        {
            //Arrange
            string numeros = "2,3,5,3";
            int expected = 13;
            int actual;
            //Act
            actual = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testea el metodo Add cuando se pasa un string 
        /// con numeros separados por saltos de linea
        /// Devuelve la suma de esos numeros 
        /// </summary>
        [TestMethod]
        public void Add_CuandoRecibeNumerosSeparadosPorSaltosDeLinea_DeberiaDevolverLaSumaDeLosNumeros()
        {
            //Arrange
            string numeros = "1\n2\n3";
            int expected = 6;
            int actual;
            //Act
            actual = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testea el metodo Add cuando se pasa un string 
        /// con numeros separados por un determinado delimitador elegido
        /// y comienza con doble barra
        /// Devuelve la suma de esos numeros
        /// </summary>
        [TestMethod]
        public void Add_CuandoRecibeNumerosSeparadosPorDelimitadorElegidoYComienzaConDobleBarra_DeberiaDevolverLaSumaDeLosNumeros()
        {
            //Arrange
            string numeros = "//;1\n2,6;2";
            int expected = 11;
            int actual;
            //Act
            actual = Calculadora.Add(numeros);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Testea el metodo Add cuando se pasa un string
        /// con numeros negativos
        /// Devuelve una excepcion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_CuandoRecibeNumerosNegativo_DeberiaDevolverException()
        {
            //Arrange
            string numeros = "2,-5";
            int actual;
            //Act
            actual = Calculadora.Add(numeros);
        }
    }
}
