using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerPruebas
{
   
        public static class iva
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Resultado del IVA: " + calculoIVA(10));



                Console.ReadKey();
            }
            public static double calculoIVA(double numero)
            {
                numero = numero * 1.21;
                return numero;
            }
        }



    
}
