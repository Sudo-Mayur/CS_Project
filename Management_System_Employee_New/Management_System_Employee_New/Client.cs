using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject_1_2_2022
{
    internal class Client
    {
        Employee_operations operation = new Employee_operations();
        List<Employee> Employees = new List<Employee>();
        Employee emp = new Employee();

        public void AddEmployee()
        {
            Employee emp = operation.AcceptEmployeeData();
            Employees = operation.AddEmployee(emp);
            operation.PrintEmployees(ref Employees);
        }
        public void UpdateEmployee()
        {

            Employee emp = new Employee();
            Console.WriteLine("Enter Emp No which you want to update ");
            int empNo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name");
            //string updatedName = Console.ReadLine();
            //Console.WriteLine("Update Dept name");
            //string updateDept = Console.ReadLine();
            //Console.WriteLine("UpdateDesign");
            //string updateDesig = Console.ReadLine();
            //Console.WriteLine("Update salary");
            //int updateSalary = Convert.ToInt32(Console.ReadLine());
            //Employees = operation.UpdateEmployee(Employees, empNo);
            //operation.PrintEmployees(ref Employees);
            // Employee emp = operation.AcceptEmployeeData();
            Employees = operation.UpdateEmployee(emp, empNo);

        }
        public void Deleteemployee()
        {

            Console.WriteLine("Enter the number ");
            int empNo = Convert.ToInt32(Console.ReadLine());
            Employees = operation.DeleteEmployee(emp, empNo);
            operation.PrintEmployees(ref Employees);
        }
        public void SearchEmployee()
        {
            Console.WriteLine("Enter the number ");
            int empNo = Convert.ToInt32(Console.ReadLine());
            Employees = operation.SearchEmployee(Employees, empNo);
            operation.PrintEmployees(ref Employees);
        }
        public void DisplayEmployee()
        {
            Console.Write("Display Employee");
            Employees = operation.DisplayEmployee(emp);
            operation.PrintEmployees(ref Employees);
        }
        public void Dept_Name()
        {
            Console.WriteLine("Enter the Department name");
            string deptName = Console.ReadLine();
            operation.Dept_Name(emp, deptName);
            // operation.PrintEmployees(ref Employees);
        }
        public void Designation()
        {

            Console.WriteLine("Enter the Department name");
            string designation = Console.ReadLine();
            operation.DesigNation(emp, designation);
            //operation.PrintEmployees(ref Employees);
        }

    }
}
