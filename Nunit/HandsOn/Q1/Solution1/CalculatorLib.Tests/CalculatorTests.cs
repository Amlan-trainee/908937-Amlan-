using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLib;
namespace CalculatorLib.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(4, 5);
            Assert.That(sum, Is.EqualTo(9));
        }
        [Test]
        public void AddFailTestCase()
        {
            Calculator calculator = new Calculator();
            int sum = calculator.Add(0, 5);
            Assert.That(sum, Is.EqualTo(0));
        }
    }
}
