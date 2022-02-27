using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Practice
{
    public class Employee
    {
        private int emp_Id;
        public int Emp_Id
        {
            get { return emp_Id;}
            set { emp_Id = value;}
        }

        private string emp_Name;
        public string Emp_Name
        {
            get { return emp_Name;}
            set { emp_Name = value;}
        }

        private string emp_Dept;
        public string Emp_Dept
        {
            get { return emp_Dept;}
            set { emp_Dept = value;}
        }

        private string emp_Designation;
        public string Emp_Designation
        {
            get { return emp_Designation;}               
            set { emp_Designation = value;}
        }

        private int emp_Salary;
        public int Emp_Salary
        {
            get { return emp_Salary;}
            set { emp_Salary = value;}
        }

    }
}
