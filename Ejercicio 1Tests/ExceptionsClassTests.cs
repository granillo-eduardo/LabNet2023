using Microsoft.VisualStudio.TestTools.UnitTesting;
using lanNetPractica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanNetPractica2.Tests
{
    [TestClass()]
    public class DivisionClassTests
    {
        [TestMethod()]        
        public void DividirTest()
        {
            decimal valor1 = 30;
            decimal valor2 = 3;
            decimal resultado = 10;

            decimal resultado2 = Divisions.Dividir(valor1, valor2); 

            Assert.AreEqual(resultado, resultado2);  
                        
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Dividir() 
        {
            decimal valor1 = 30;    
            Divisions.DividirEnCero(valor1);
        }
    }
}