using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Sample_Web_App.Models
{
    public partial class Employee
    {
        [Required(ErrorMessage = "EmpNo is Required")]
        public int EmpNo { get; set; }
        [Required(ErrorMessage = "EmpName is Required")]
        [Remote(action: "ValidateEmpName", controller: "Employee", ErrorMessage = "EmpName is not in correct format")]
        [Name(ErrorMessage = " EmpName MUST start from Upper Case character and does not have Digit and Special character")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Salary is Required")]
        [NonNegative(ErrorMessage = "Salary must be Positive value")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Designation is Required")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "DeptNo is Required")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        public double Tax { get; set; }

        public virtual Department DeptNoNavigation { get; set; }
    }
}
