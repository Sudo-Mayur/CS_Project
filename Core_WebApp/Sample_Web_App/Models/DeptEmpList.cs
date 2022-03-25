using System.Collections.Generic;

namespace Sample_Web_App.Models
{
    public class DeptEmpList
    {
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }
        public int DeptNo { get; set; }

        public List<EmployeeData> EmployeesData { get; set; }

    }
}
