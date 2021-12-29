using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EjerPruebas;

namespace Prueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcularIVa()
        {
            int numero1 = 10;

            

            var resultado = iva.calculoIVA(numero1);
            var valorEsperado = 2.1;
            Assert.AreEqual(valorEsperado, resultado);

        }
    }
}
