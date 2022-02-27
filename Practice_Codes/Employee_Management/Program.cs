using System;

namespace Employee_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee ID");
            employee.EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employee.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            employee.EmployeeDept =Console.ReadLine();
            Console.WriteLine("Enter Employee Desigation");
            employee.EmployeeDesiganation=Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            employee.EmployeeSalary= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("EmployeeID \t EmployeeName \t EmployeeDept \t EmployeeDesiganation \t EmployeeSalary");
            Console.WriteLine($"{ employee.EmployeeID} \t\t {employee.EmployeeName} \t\t {employee.EmployeeDept} \t\t {employee.EmployeeDesiganation} \t\t {employee.EmployeeSalary}");

          


        }
    }
}
