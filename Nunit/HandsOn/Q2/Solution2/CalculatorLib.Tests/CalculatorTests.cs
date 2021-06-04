using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalculatorLib;
using System.Collections;

namespace CalculatorLib.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase, Category("Calculation"), Order(1)]

        public void AddTest_if()
        {
            Calculator c = new Calculator();
            int result = c.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));

        }
        [TestCase, Category("Calculation"), Order(2)]
        public void AddTest_else()
        {
            Calculator c = new Calculator();
            int result = c.Add(-8, -1);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase, Category("Calculation"), Order(3)]
        public void DivisionPAss_Test()
        {
            Calculator c = new Calculator();
            int result = c.Divide(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [TestCase, Category("Calculation"), Order(4)]
        public void DivisionElse_Test()
        {
            Calculator c = new Calculator();
            int result = c.Divide(2, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase, Category("Calculation"), Order(5)]
        public void MultiplicationIf_Test()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(4, 2);
            Assert.That(result, Is.EqualTo(8));
        }
        [TestCase, Category("Calculation"), Order(6)]
        public void MultiplicationElse_Test()
        {
            Calculator c = new Calculator();
            int result = c.Multiply(2, 0);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase, Category("Calculation"), Order(7)]
        public void SubstractionIf_Test()
        {
            Calculator c = new Calculator();
            int result = c.Subtract(4, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        [TestCase, Category("Calculation"), Order(8)]
        public void SubstractionElse_test()
        {
            Calculator c = new Calculator();
            int result = c.Subtract(-2, -4);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]

        [TestCaseSource(typeof(AddCases))]
        public void AddTestPass(int a, int b)
        {
            Calculator c = new Calculator();
            int result = c.Add(a, b);
            Assert.That(result, Is.EqualTo(a + b));
        }
        class AddCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[] { 1, 1 };
                yield return new object[] { 50, 50 };
                yield return new object[] { 22, 13 };

            }
        }
    }
}
