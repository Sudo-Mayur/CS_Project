using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class EmployeeManagement
    {
        static void Main(string[] args)
        {

            EmployeeManagement obj_Company = new EmployeeManagement();
            List<AbcCmpany> employeeList = new List<AbcCmpany>();
            

               


        public void Function_Add_Employee(List<AbcCmpany> employeeList)
        {
            AbcCmpany obj_Comapny1 = new AbcCmpany();
            Console.Write("Enter Employee Id:");
            obj_Comapny1.emp_Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            obj_Comapny1.emp_Name = Console.ReadLine();
            Console.Write("Enter Employee Addess:");
            obj_Comapny1.emp_Address = Console.ReadLine();
            Console.Write("Enter Employee Designation:");
            obj_Comapny1.emp_Designation = Console.ReadLine();

            employeeList.Add(obj_Comapny1);
            Console.WriteLine("Employee Deatil Added Successfully...!!!!:");
        }

        public void Function_Display_Employee(List<AbcCmpany> employeeList)
        {
            Console.WriteLine("****************************Employee Details****************************************");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Employee Id\tEmployee Name\tEmployee Addess\tEmployee Designation");
            Console.WriteLine("------------------------------------------------------------------------------------");
            foreach (AbcCmpany i in employeeList)
            {
                Console.WriteLine(i.emp_Id + "      \t|  " + i.emp_Name + " \t| " + i.emp_Address + "   \t|  " + i.emp_Designation);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
        }

        public AbcCmpany Function_Search(List<AbcCmpany> employeeList, int search_Id)
        {
            return employeeList.Find(emp => emp.emp_Id == search_Id);
        }


        public void Fucntion_Modify_Employee(List<AbcCmpany> employeeList, AbcCmpany obj_Modify)
        {
            Console.WriteLine("Chose Option for Modify Employee Detail:");
            Console.WriteLine("1.Id 2.Name 3.Address 4.Designation");
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
                    obj_Modify.emp_Address = new_Address;
                    break;
                case 4:
                    Console.WriteLine("Enter New Employee Designation:");
                    string new_Designation = Console.ReadLine();
                    obj_Modify.emp_Designation = new_Designation;
                    break;
                default:
                    Console.WriteLine("Invalide Choise....");
                    break;
            }
            // employeeList.Add(obj_Modify);
        }

        public void Function_Remove(List<AbcCmpany> employeeList, AbcCmpany obj_Modify)
        {
            employeeList.Remove(obj_Modify);
            Console.WriteLine("1 Record Removed SuccessFully....!!!");
        }


    }
}