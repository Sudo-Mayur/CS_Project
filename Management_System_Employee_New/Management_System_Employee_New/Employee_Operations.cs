using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MiniProject_1_2_2022
{
    internal class Employee_operations
    {
        private List<Employee> employees;
        public Employee_operations()
        {
            employees = new List<Employee>();
        }

        public List<Employee> UpdateEmployee(Employee emp, int empNo)
        {


            try
            {
                foreach (Employee employee in employees)
                {
                    //Console.WriteLine("Enter EMpNo you want to update");
                    //employee.EmpNo =Convert.ToInt32(Console.ReadLine());

                    if (employee.EmpNo == empNo)
                    {
                        Console.WriteLine("Enter EMpName you want to update");
                        employee.EmpName = Console.ReadLine();
                        Console.WriteLine("Enter DeptName you want to update");
                        employee.DeptName = Console.ReadLine();

                        Console.WriteLine("Enter Designation you want to update");
                        employee.Designation = Console.ReadLine();
                        Console.WriteLine("Enter Salary you want to update");
                        employee.Salary = int.Parse(Console.ReadLine());

                        return employees;
                    }
                }
                throw new Exception($"Employee with EmpNo={empNo} doesnot exist");

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Employee> DeleteEmployee(Employee emp, int empNo)
        {

            try
            {
                foreach (Employee employee in employees)
                {
                    if (employee.EmpNo == empNo)
                    {
                        employees.Remove(employee);
                        return employees;
                    }
                }
                throw new Exception($"Employee with {empNo} doesnot exists");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employees;

        }
        public List<Employee> AddEmployee(Employee emp)
        {

            employees.Add(emp);


            /*Dictionary<string, Employee> Dictionary = new Dictionary<string, Employee>();
             Dictionary.Add(emp.DeptName, emp);
             foreach (var item in Dictionary)
             {
                 Console.WriteLine("{0} and {1},{2},{3},{4}", item.Key, item.Value.EmpNo, item.Value.EmpName, item.Value.Designation, item.Value.Salary);
             }*/
            return employees;


        }
        public List<Employee> DisplayEmployee(Employee emp)
        {

            return employees;
        }
        public List<Employee> SearchEmployee(List<Employee> emp, int empNo)
        {
            employees = emp;
            try
            {
                foreach (Employee employee in employees)
                {
                    if (employee.EmpNo == empNo)
                    {
                        return employees;

                    }
                }
                throw new Exception($"The Employee No {empNo} is not valid");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employees;
        }
        public void Dept_Name(Employee emp, string deptName)
        {

            try
            {
                foreach (Employee employee in employees)
                {
                    if (employee.DeptName == deptName)
                    {
                        Console.WriteLine(employee.EmpName);

                    }
                    //throw new Exception($"Employee with deptName = {deptName} is not valid");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public void DesigNation(Employee emp, string designation)
        {

            try
            {
                foreach (Employee employee in employees)
                {
                    if (employee.Designation == designation)
                    {
                        Console.WriteLine(employee.EmpName);
                    }
                }
                throw new Exception($"Employee with Designation={designation} is not valid");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Employee AcceptEmployeeData()
        {
            Employee employee = new Employee();
            //Validation for Employee Number
            Console.WriteLine("\nEnter Employee Number");
            try { employee.EmpNo = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            int d = 0;
            do
            {
                try
                {
                    if (employee.EmpNo >= 0)
                    {
                        d = 0;
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct Employe No.");
                        employee.EmpNo = Convert.ToInt32(Console.ReadLine());
                        d++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (d > 0);
            Console.WriteLine("Enter Employee Name");
            employee.EmpName = Console.ReadLine();
            //Validation for Employee Name
            Regex re = new Regex("[A-Z][A-Za-z ]+[A-Za-z]$");
            int g = 0;
            do
            {
                if (re.IsMatch(employee.EmpName))
                {
                    g = 0;
                }
                else
                {
                    Console.WriteLine("Please enter correct name");
                    employee.EmpName = Console.ReadLine();
                    g++;
                }
            } while (g > 0);
            Console.WriteLine("Enter Department Name");
            employee.DeptName = Console.ReadLine();
            //Validation for Department
            int c = 0;
            do
            {
                if (employee.DeptName == "IT" || employee.DeptName == "HR" || employee.DeptName == "Admin" || employee.DeptName == "Sales" || employee.DeptName == "Account")//employee.Designation.Equals(designation)
                {
                    c = 0;
                }
                else
                {
                    Console.WriteLine("Please enter correct department");
                    employee.DeptName = Console.ReadLine();
                    c++;
                }
            } while (c > 0);
            Console.WriteLine("Enter Designation");
            employee.Designation = Console.ReadLine();
            //Validation for Designation
            int b = 0;
            do
            {
                if (employee.Designation == "Manager" || employee.Designation == "Engineer" || employee.Designation == "Clerk" || employee.Designation == "Staff" || employee.Designation == "Intern")//employee.Designation.Equals(designation)
                {
                    b = 0;
                }
                else
                {
                    Console.WriteLine("Please enter correct designation");
                    employee.Designation = Console.ReadLine();
                    b++;
                }
            } while (b > 0);
            //validation for Salary
            Console.WriteLine("Enter Salary");
            try { employee.Salary = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            int a = 0;
            do
            {
                try
                {
                    if (employee.Salary <= 0)
                    {
                        Console.WriteLine("Please enter correct salary amount");
                        employee.Salary = Convert.ToInt32(Console.ReadLine());
                        a++;
                    }
                    else
                    {
                        a = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (a > 0);
            return employee;


        }

        public void PrintEmployees(ref List<Employee> emp)
        {

            Console.WriteLine("EmpNo \t\t EmpName \t DeptName \t Designation \t Salary");
            foreach (Employee employee in emp)
            {
                Console.WriteLine($"{employee.EmpNo} \t\t {employee.EmpName} \t\t\t {employee.DeptName} \t {employee.Designation} \t {employee.Salary}");
            }

        }


    }
}
