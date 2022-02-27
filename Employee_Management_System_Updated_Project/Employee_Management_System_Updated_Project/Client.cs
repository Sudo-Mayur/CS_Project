using System;
using System.Collections.Generic;

namespace MiniProject_EmployeeData
{
    internal class Client
    {
        EmployeeOpeartions operation = new EmployeeOpeartions();
        List<Employee> Employees = new List<Employee>();

        //Method for writing an Employee

        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        //Method for Adding an Employee

        public List<Employee> AddEmployee(Employee emp)
        {
            Employees.Add(emp);
            return Employees;
        }

        //Method for Updating an Employee

        public List<Employee> UpdateEmployee(List<Employee> emp, int emNo, string updateName, string updateDept, string updateDesignation, int updateSalary)
        {
            try
            {
                Employees = emp;
                foreach (Employee employee in Employees)
                {
                    if (employee.EmpNo == emNo)
                    {
                        employee.EmpName = updateName;
                        employee.DeptName = updateDept;
                        employee.Designation = updateDesignation;
                        employee.Salary = updateSalary;
                        return Employees;
                    }
                }
                throw new Exception($"Employee with EmpNo = {emNo} does not exist, Please enter correct EmpNo");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Employees;
            }

        }

        //Method for Deleting an Employee

        public List<Employee> DeleteEmployee(List<Employee> emp, int emNo)
        {
            try
            {
                Employees = emp;
                foreach (Employee employee in Employees)
                {
                    if (employee.EmpNo == emNo)
                    {
                        Employees.Remove(employee);
                        Console.WriteLine($"Employee with EmpNo = {emNo} has been deleted from database.");
                        return Employees;
                    }

                }

                throw new Exception($"Employee with EmpNo = {emNo} does not exist, Please enter correct EmpNo");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Employees;
            }

        }

        //Method for Searching an Employee

        public List<Employee> SearchEmployee(List<Employee> emp, int emNo)
        {
            try
            {
                Employees = emp;
                foreach (Employee employee in Employees)
                {
                    if (employee.EmpNo == emNo)
                    {
                        Console.WriteLine($"\nEmpNo = {employee.EmpNo}\nEmpName = {employee.EmpName}\nDeptName = {employee.DeptName}\nDesignation = {employee.Designation}\nSalary = {employee.Salary}\n");
                        return Employees;

                    }
                }

                throw new Exception($"Employee with EmpNo = {emNo} does not exist, Please enter correct EmpNo");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Employees;
            }

        }

       



    }

}
