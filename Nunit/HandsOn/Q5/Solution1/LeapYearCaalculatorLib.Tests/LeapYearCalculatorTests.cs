using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCaalculatorLib.Tests
{
    [TestFixture]
   public class LeapYearCalculatorTests
    {
        [Test]
        public void IsLeapYearTest()
        {
            var leap = new LeapYearCalculator();
            var res = leap.IsLeapYear(2000);
            var exp = 1;
            Assert.That(res, Is.Not.Null);
            Assert.That(exp, Is.EqualTo(res));
        }
        [Test]
        public void IsNotLeapYearTest()
        {
            var leap = new LeapYearCalculator();
            var res = leap.IsLeapYear(1999);
            var exp = 0;
            Assert.That(res, Is.Not.Null);
            Assert.That(exp, Is.EqualTo(res));
        }
        [Test]
        public void IsNotValidYear()
        {
            var leap = new LeapYearCalculator();
            var res = leap.IsLeapYear(1600);
            var exp = -1;
            Assert.That(res, Is.Not.Null);
            Assert.That(exp, Is.EqualTo(res));
        }
    }
}
