using System;
using System.Data.Entity;
using System.Linq;

using System.ComponentModel.DataAnnotations;

namespace EmployeeService.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float salary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }



    }
}