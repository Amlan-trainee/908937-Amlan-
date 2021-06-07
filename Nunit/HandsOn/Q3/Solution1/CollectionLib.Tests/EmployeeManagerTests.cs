using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CollectionsLib;

namespace CollectionLib.Tests
{
    [TestFixture]
   public class EmployeeManagerTests
    {
        List<Employee> employeelist;
        [Test]
        public void TestCheckForNull()
        {
            var emp = new EmployeeManager();
            var emplist = emp.GetEmployees();
            var expected= new List<Employee>
            {
                new Employee { EmpId=100, EmpName="John",DOJ=DateTime.Now.AddYears(-5),Salary=30000},
                new Employee { EmpId=101, EmpName="Mary",DOJ=DateTime.Now.AddYears(-2),Salary=10000},
                new Employee { EmpId=102, EmpName="Steve",DOJ=DateTime.Now.AddYears(-2),Salary=10000},
                new Employee { EmpId=103, EmpName="Allen",DOJ=DateTime.Now.AddYears(-7),Salary=50000},
            };
            CollectionAssert.AllItemsAreNotNull(emplist);
            var empIdCheck = emplist.Where(n => n.EmpId == 100);
            CollectionAssert.AreEqual(expected, emplist, new EmployeeComparer());
        }
       

    }
}
