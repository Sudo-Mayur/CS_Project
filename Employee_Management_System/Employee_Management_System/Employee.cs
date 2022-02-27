using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Employee_Management_System
{
    public class Employee
    {
        private int id;
        public int emp_Id
        {
            get { return id; }
            set { id = value; }     
        }
        private string name;
        public string emp_Name
        {
            get { return name; }
            set { name = value; }
        }
        private string Dept;
        public string emp_Dept
        {
            get { return Dept; }
            set { Dept = value; }

        }
        private string Desigation;
        public string emp_Designation
        {
            get { return Desigation; }
            set { Desigation = value; }
        }
        private int Salary;
        public int emp_salary
        {
            get { return Salary; }
            set { Salary = value; }
        }


    }

}
