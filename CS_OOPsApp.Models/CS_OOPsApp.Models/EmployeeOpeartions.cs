using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPsApp.Models
{
    internal class EmployeeOpeartions
    {
        private List<Employee> Employees;
        public EmployeeOpeartions()
        {
            Employees = new List<Employee>();
        }

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public List<Employee> AddEmployee(Employee emp)
        {
            Employees.Add(emp);
            return Employees;
        }
    }
}
