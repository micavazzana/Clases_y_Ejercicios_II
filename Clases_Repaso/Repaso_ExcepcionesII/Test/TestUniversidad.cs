using BibliotecaUniversidad;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestUniversidad
    {
        List<Alumno> alumnoList;
        
        [TestInitialize]
        public void TestInicializador()
        {
            alumnoList = Universidad.Alumnos;
        }

        [TestMethod]
        public void TestLogin_CuandoRecibeLosDatosCorrectos_SeEsperaQueSeaTrue()
        {
            //Arrange
            int datoIdCorrecto = 123123;
            string datoPassCorrecto = "lucas123";
            bool resultado;

            //Act
            resultado = Universidad.Loguear(datoIdCorrecto, datoPassCorrecto);

            //Assert
            Assert.IsTrue(resultado);
        }

        [ExpectedException(typeof(UnauthorizedAccessException))]
        [TestMethod]
        public void TestLogin_CuandoRecibeLosDatosIncorrectos_SeEsperaException()
        {
            //Arrange
            int datoIdIncorrecto = 1;
            string datoPassIncorrecto = "fs";

            //Act
            Universidad.Loguear(datoIdIncorrecto, datoPassIncorrecto);
        }

        [DataRow(10,"asd")]
        [DataRow(1, "qwe")]
        [DataRow(22, "zxc")]
        [ExpectedException(typeof(UnauthorizedAccessException))]
        [TestMethod]
        public void TestLogin_CuandoRecibeLosDatosIncorrectosParametrizados_SeEsperaException(int idPrueba, string passPrueba)
        {
            Universidad.Loguear(idPrueba, passPrueba);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void TestLogin_CuandoRecibeLaContraseniaNull_SeEsperaNullReferenceException()
        {
            //Arrange
            int datoIdIncorrecto = 1;
            string datoPassNull = null;

            //Act
            Universidad.Loguear(datoIdIncorrecto, datoPassNull);
        }

        [TestMethod]
        public void Test_CuandoLaListaEstaCargada_SeEsperaQueNoSeaNullYAlHaberDatosDeTrue()
        {
            Assert.IsNotNull(alumnoList);
            Assert.IsTrue(alumnoList.Count > 1);
            Console.WriteLine($"Cant: {alumnoList.Count}");
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void Test_CuandoSeQuiereConvertirCadaAlumnoAString_SeEsperaNullReferenceException()
        {
            foreach(Alumno alumno in alumnoList)
            {
                alumno.ToString();
            }
        }
    }
}
