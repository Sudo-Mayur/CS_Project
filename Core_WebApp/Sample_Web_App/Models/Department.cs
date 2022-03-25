using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Sample_Web_App.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }
        [Required(ErrorMessage = "DeptNo is Required")]
        public int DeptNo { get; set; }
        [Required(ErrorMessage = "DeptName is Required")]

        public string DeptName { get; set; }
        [Required(ErrorMessage = "Location is Required")]

        public string Location { get; set; }
        [Required(ErrorMessage = "Capacity is Required")]
        [NonNegative]
        public int Capacity { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
