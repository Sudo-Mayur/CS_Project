using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace Employee_Management_System
{
    class EmployeeOperation
    {

        List<Employee> employeeList   = new List<Employee>();

        public void Function_Add_Employee(List<Employee> employeeList)
        {
            Employee obj_Comapny1 = new Employee();
            try
            {
                Console.Write("Enter Employee Id:");
                obj_Comapny1.emp_Id = Convert.ToInt32(Console.ReadLine());
                if (obj_Comapny1.emp_Id <= 0)
                {
                    throw new Exception("Employee Id must be Positive");
                }

                Console.Write("Enter Employee Name:");
                obj_Comapny1.emp_Name = Console.ReadLine();
               
                Console.Write("Enter Employee Department:");
                Console.WriteLine("1)IT, 2)HRD, 3)Sales, 4)Admin, 5)Account");
                obj_Comapny1.emp_Dept = Console.ReadLine();
                switch (obj_Comapny1.emp_Dept)
                {
                    case "IT":
                        obj_Comapny1.emp_Dept = "IT";
                        break;
                    case "HRD":
                        obj_Comapny1.emp_Dept = "HRD";
                        break;
                    case "Sales":
                        obj_Comapny1.emp_Dept = "Sales";
                        break;
                    case "Admin":
                        obj_Comapny1.emp_Dept = "Admin";
                        break;
                    case "Account":
                        obj_Comapny1.emp_Dept = "Account";
                        break;
                    default:
                        throw new Exception("The Department choice is wrong");
                }

                Console.Write("Enter Employee Designation:");
                Console.WriteLine("1) Manager, 2)Engineer, 3)Clerk, 4)Staff");
                obj_Comapny1.emp_Designation = Console.ReadLine();
                switch(obj_Comapny1.emp_Designation)
                {
                    case "Manager":
                        obj_Comapny1.emp_Designation = "Manager";
                        break;
                    case "Engineer":
                        obj_Comapny1.emp_Designation = "Engineer";
                        break;
                    case "Clerk":
                        obj_Comapny1.emp_Designation = "Clerk";
                        break;
                    case "Staff":
                        obj_Comapny1.emp_Designation = "Staff";
                        break;
                    default:
                        throw new Exception("The Department choice is wrong");
                }
                Console.Write("Enter Employee Salary:");
                obj_Comapny1.emp_salary = Convert.ToInt32(Console.ReadLine());
                if (obj_Comapny1.emp_salary < 0)
                {
                    throw new Exception("Employee Salary must be Positive");
                }              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            employeeList.Add(obj_Comapny1);
            Console.WriteLine("Employee Deatil Added Successfully...!!!!:");

        }

        public void Function_Display_Employee(List<Employee> employeeList)
        {
            Console.WriteLine("****************************Employee Details****************************************");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Employee Id\tEmployee Name\tEmployee Department\tEmployee Designation\tEmployee Salary");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            foreach (Employee i in employeeList)
            {
                Console.WriteLine(i.emp_Id + "      \t|  " + i.emp_Name + " \t| " + i.emp_Dept + "   \t\t\t|  " + i.emp_Designation + "    \t \t|  " + i.emp_salary);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }

        public Employee Function_Search(List<Employee> employeeList, int search_Id)
        {
            return employeeList.Find(emp => emp.emp_Id == search_Id);
        }


        public void Fucntion_Update_Employee(List<Employee> employeeList, Employee obj_Modify)
        {
            Console.WriteLine("Chose Option for Modify Employee Detail:");
            Console.WriteLine("1.Id 2.Name 3.Address 4.Designation 5.Salary");
            int modify_number = Convert.ToInt32(Console.ReadLine());
            switch (modify_number)
            {
                case 1:
                    Console.WriteLine("Enter New Employee Id:");
                    int new_Id = Convert.ToInt32(Console.ReadLine());
                    obj_Modify.emp_Id = new_Id;
                    break;
                case 2:
                    Console.WriteLine("Enter New Employee Name:");
                    string new_Name = Console.ReadLine();
                    obj_Modify.emp_Name = new_Name;
                    break;
                case 3:
                    Console.WriteLine("Enter New Employee Address:");
                    string new_Address = Console.ReadLine();
                    obj_Modify.emp_Dept = new_Address;
                    break;
                case 4:
                    Console.WriteLine("Enter New Employee Designation:");
                    string new_Designation = Console.ReadLine();
                    obj_Modify.emp_Designation = new_Designation;
                    break;
                case 5:
                    Console.WriteLine("Enter New Employee Salary:");
                    int new_salary = Convert.ToInt32(Console.ReadLine());
                    obj_Modify.emp_salary = new_salary;
                    break;
                default:
                    Console.WriteLine("Invalide Choise....");
                    break;
            }
           
        }

        public void Function_Remove(List<Employee> employeeList, Employee obj_Modify)
        {
            employeeList.Remove(obj_Modify);
            Console.WriteLine("1 Record Removed SuccessFully....!!!");
        }


    }
}
