using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLib;

namespace CalculatorLib_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
  
        public void Divide_Test()
        {
            var calc = new Calculator();
           Assert.Throws<DivideByZeroException>(() => calc.Divide("2,0"));
        } 
  }
}
    