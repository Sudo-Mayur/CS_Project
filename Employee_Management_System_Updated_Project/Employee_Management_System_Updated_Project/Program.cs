using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using MiniProject_EmployeeData;
namespace CS_OOPSApp
{
    internal class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            Client client = new Client();
            //Switch case for taking users input
            Employee emp;
            do
            {
                Console.WriteLine("**************************EMPLOYEE MANAGEMENT SYSTEM ******************************");
                Console.WriteLine("1. Add  an Employee");
                Console.WriteLine("2. View Employee details");
                Console.WriteLine("3. Search Employee details");
                Console.WriteLine("4. Update Employee details");
                Console.WriteLine("5. delete Employee details");
               
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        emp = AcceptEmployeeData();
                        employees = client.AddEmployee(emp);
                        break;

                    case 2:
                        employees = client.GetEmployees();
                        PrintEmployees(ref employees);
                        break;

                    case 3:
                        emp = AcceptEmpNo();
                        employees = client.SearchEmployee(employees, emp.EmpNo);
                        break;

                    case 4:
                        emp = AcceptEmployeeData();
                        employees = client.UpdateEmployee(employees, emp.EmpNo, emp.EmpName, emp.DeptName, emp.Designation, emp.Salary);
                        break;

                    case 5:
                        emp = AcceptEmpNo();
                        employees = client.DeleteEmployee(employees, emp.EmpNo);
                        break;

                    default:
                        Console.WriteLine("Please enter correct choice number");
                        break;
                }
            }while (true);
            }
        

        //Method that returns Employee Object
        //Method for validation of employee details
        static Employee AcceptEmployeeData()
        {
            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();
            Client client = new Client();

            //Validation for Employee Number

            Console.WriteLine("\nEnter Employee Number");
            try { employee.EmpNo = Convert.ToInt32(Console.ReadLine()); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            int d = 0;
            do
            {
                try
                {
                    if (employee.EmpNo > 0)    
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

            Console.WriteLine("Enter Department Name : 1)IT  2)HR  3)Admin  4)Sales  5)Account");
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

            Console.WriteLine("Enter Designation : 1)Manager  2)Engineer  3)Clerk  4)Staff  5)Intern");
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

        //Method for Search and Delete Employee

        static Employee AcceptEmpNo()
        {
            Employee employee = new Employee();
            Console.WriteLine("\nEnter Employee Number ");
            employee.EmpNo = Convert.ToInt32(Console.ReadLine());
            return employee;
        }

        //Method for Printing Employee Details

        static void PrintEmployees(ref List<Employee> emps)
        {
            foreach (Employee emp in emps)
            {

                Console.WriteLine($"\nEmpNo = {emp.EmpNo}\nEmpName = {emp.EmpName}\nDeptName = {emp.DeptName}\nDesignation = {emp.Designation}\nSalary = {emp.Salary}\n");
                Console.WriteLine("----------------------------------------");
            }
        }

    }
}
