using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_Practice
{
    public class Employee_Operation
    {
        List<Employee> employeeList = new List<Employee>();
        public void Function_Add_Employee(List<Employee> employeeList)
        {
            Employee obj_Comapny1 = new Employee();
            Console.Write("Enter Employee Id:");
            obj_Comapny1.Emp_Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            obj_Comapny1.Emp_Name = Console.ReadLine();
            Console.Write("Enter Employee Department:");
            obj_Comapny1.Emp_Dept = Console.ReadLine();
            Console.Write("Enter Employee Designation:");
            obj_Comapny1.Emp_Designation = Console.ReadLine();
            Console.Write("Enter Employee Salary:");
            obj_Comapny1.Emp_Salary = Convert.ToInt32(Console.ReadLine());
            employeeList.Add(obj_Comapny1);
            Console.WriteLine("Employee Deatil Added Successfully...!!!!:");
        }
    }
    public class Program
    {
        private static List<Employee> employeeList;

        static void Main(string[] args)
        {
            Employee_Operation obj_Company = new Employee_Operation();
            char ans;
            do
            {
                Console.Clear();
                Console.WriteLine("**************************EMPLOYEE MANAGEMENT SYSTEM MENU******************************");
                Console.WriteLine("1. Add  an Employee");
                Console.WriteLine("2. View Employee details");
                Console.WriteLine("3. Search Employee details");
                Console.WriteLine("4. Modify Employee details");
                Console.WriteLine("5. Remove Employee details");
                Console.WriteLine("6. Exit");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.Write("Enter Your Choise Here:-");
                int choose_number = Convert.ToInt32(Console.ReadLine());
                switch (choose_number)
                {
                    case 1:
                        obj_Company.Function_Add_Employee(employeeList);
                        break;
                    default:
                        Console.WriteLine("Invalide Choise....!!! Please Enter Correct Choice...!!!");
                        break;
                }
                Console.Write("Would You Like To Continue(Y/N):");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y' || ans == 'Y');


        }


    }
}
