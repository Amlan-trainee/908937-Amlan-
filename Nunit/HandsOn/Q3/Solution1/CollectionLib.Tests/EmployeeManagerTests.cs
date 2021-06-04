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
       /* [Test]
        public void TestCheck_ForUniqueId()
        {
            try
            {
                EmployeeManager em = new EmployeeManager();
                employeelist = em.GetEmployees();
                for (int i = 0; i < employeelist.Count; i++)
                {
                    for (int j = i + 1; j < employeelist.Count; j++)
                    {
                        Assert.AreNotEqual(employeelist[i].EmpId, employeelist[j].EmpId);
                    }
                }
            }
            catch (Exception)
            {
                Assert.Fail("Test case is Failed as Id is not unique");
            }
        }

        [Test]
        public void TestCheck_ForIDExistence()
        {
            int searchId = 100;
            try
            {
                EmployeeManager em = new EmployeeManager();
                employeelist = em.GetEmployees();
                var findEmployee = employeelist.Where(x => x.EmpId == searchId).FirstOrDefault();
                Assert.IsNotNull(findEmployee);

            }
            catch (Exception)
            {
                Assert.Fail("The searched id" + searchId + "is not found in the list");
            }
        }
        [Test]
        public void TestCheck_ForAnyNUllValueInCollection()
        {
            try
            {
                EmployeeManager em = new EmployeeManager();
                employeelist = em.GetEmployees();
                foreach (var data in employeelist)
                {
                    Assert.IsNotNull(data.EmpId);
                    Assert.IsNotNull(data.EmpName);
                    Assert.IsNotNull(data.DOJ);
                    Assert.IsNotNull(data.Salary);
                }
            }
            catch (Exception)
            {
                Assert.Fail("The data in the collection should not be null");
            }
        }
        [Test]
        public void TestCheck_ForWhetherListsAreSame()
        {
            try
            {
                EmployeeManager em = new EmployeeManager();
                employeelist = em.GetEmployees();
                List<Employee> employeelistbyDOJ = em.GetEmployeesWhoJoinedInPreviousYears();
                CollectionAssert.AreEqual(employeelist, employeelistbyDOJ);
            }
            catch (Exception)
            {
                Assert.Fail("Both employeelists are not same");
            }
        }*/

    }
}
