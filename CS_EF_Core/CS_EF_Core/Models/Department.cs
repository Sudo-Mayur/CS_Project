using System;
using System.Collections.Generic;

namespace CS_EF_Core.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; } = null!;
        public string? Location { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
