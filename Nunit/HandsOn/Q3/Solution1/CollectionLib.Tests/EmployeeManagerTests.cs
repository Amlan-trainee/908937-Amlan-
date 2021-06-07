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
        public void NoNUllValueInCollectionTest()
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
        public void IDExistsTest()
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
        public void UniqueEmployee_Test()
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
        public void ListsSameTest()
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
        }


    }
}
