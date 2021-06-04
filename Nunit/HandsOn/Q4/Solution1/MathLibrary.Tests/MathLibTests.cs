using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MathLibrary;

namespace MathLibrary.Tests
{
    [TestFixture]
    public class MathLibTests
    {
        [Test]
        [TestCaseSource(nameof(CompareTwoNumbersTestData))]
        public void TestAddTestIfArgsAreGreaterThanZero(int a, int b,int c)
        {
            MathLib math = new MathLib();
            int res = math.CompareTwoNumbers(a, b);
            Assert.That(res, Is.Not.Null);          
            Assert.That(c, Is.EqualTo(res));
        }
        private static IEnumerable<TestCaseData> CompareTwoNumbersTestData
        {
         get{
                yield return new TestCaseData(-1, 0, 0);
                yield return new TestCaseData(1, 2, -1);
                yield return new TestCaseData(2, 1, 1);
            }
        }
    }
}
