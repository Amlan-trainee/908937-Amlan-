using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeLib;
namespace EmployeeLib.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        EmployeeManager empman = new EmployeeManager();
        [Test]
        public void AddEmployee_Tests_NoEmployee()
        {
            var emp = new EmployeeManager();
            var res = emp.HeadCount;
            var exp = 0;
            Assert.That(exp, Is.EqualTo(res));
        }
        [Test]
        public void AddEmployee_Tests()
        {
            var emp = new Employee
            {
                Id = 101,
                Name = "Jojo"
            };
            var emp1 = new Employee { Id = 102, Name = "Jose" };
            empman.AddEmployee(emp);
            empman.AddEmployee(emp1);
            var headcountaft = empman.HeadCount;
            var exp = 2;
            Assert.That(exp, Is.EqualTo(headcountaft));

        }
    }
}