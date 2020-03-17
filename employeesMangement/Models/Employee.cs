using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace employeesMangement.Models
{
    public class Employee
    {
        [DisplayName("EmployeeID")]
        [Required]
        [Key]
        public string Id { get; set; }
        [DisplayName("EmployeeName")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Department")]
        [Required]
        public string Department { get; set; }
        [DisplayName("Salary")]
        [Required]
        public double Salary { get; set; }
    }
}