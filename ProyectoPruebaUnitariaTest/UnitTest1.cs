using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyectoPruebaUnitariaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var operador1 = 11;
            var operador2 = 10;
            var result = ProyectoPruebasUnitarias.ProcesadorMatematico.Sumar(operador1, operador2);
            var valorEsperado = 21;
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestResta() {

            var operador1 = 11;
            var operador2 = 10;
            var result = ProyectoPruebasUnitarias.ProcesadorMatematico.Resta(operador1, operador2);
            var valorEsperado = 1;
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestDivision() {
            var operador1 = 10;
            var operador2 = 5;
            var result = ProyectoPruebasUnitarias.ProcesadorMatematico.Division(operador1, operador2);
            var valorEsperado = 2;
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestMultiplicacion() {
            var operador1 = 10;
            var operador2 = 10;
            var result = ProyectoPruebasUnitarias.ProcesadorMatematico.Multiplicacion(operador1, operador2);
            var valorEsperado = 100;
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestPotencia() {
            var operador1 = 2;
            var operador2 = 3;
            var result = ProyectoPruebasUnitarias.ProcesadorMatematico.Potencia(operador1,operador2);
            var valorEsperado = 8;
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestRaiz() {
            var operador1 = 4;
            var operador2 = 2;
            var result = ProyectoPruebasUnitarias.ProcesadorMatematico.Raiz(operador1, operador2);
            var valorEsperado = 2;
            Assert.AreEqual(valorEsperado, result);

        }


    }
}
