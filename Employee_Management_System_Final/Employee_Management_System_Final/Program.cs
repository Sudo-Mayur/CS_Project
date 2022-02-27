using System;

namespace Employee_Management_System_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ans;
            int search_Id;
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
            }
             switch (choose_number)
            {
                case 1:
                    obj_Company.Function_Add_Employee(employeeList);
                    obj_Company.Function_Display_Employee(employeeList);
                    break;
                case 2:
                    obj_Company.Function_Display_Employee(employeeList);
                    break;
                case 3:
                    Console.WriteLine("Enter Employee Id Which You Want To Search:");
                    search_Id = Convert.ToInt32(Console.ReadLine());
                    AbcCmpany obj_search = obj_Company.Function_Search(employeeList, search_Id);
                    if (obj_search != null)
                    {
                        Console.WriteLine("Employee ID \t{0}", obj_search.emp_Id);
                        Console.WriteLine("Employee Name \t{0}", obj_search.emp_Name);
                        Console.WriteLine("Employee Address \t{0}", obj_search.emp_Address);
                        Console.WriteLine("Designation \t{0}\n", obj_search.emp_Designation);
                    }
                    else
                    {
                        Console.WriteLine("Record Not Found...!!!");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter Employee Id Which You Want To Search:");
                    search_Id = Convert.ToInt32(Console.ReadLine());
                    AbcCmpany obj_Modify = obj_Company.Function_Search(employeeList, search_Id);
                    if (obj_Modify != null)
                    {
                        Console.WriteLine("Employee ID      :" + obj_Modify.emp_Id);
                        Console.WriteLine("Employee Name    :" + obj_Modify.emp_Name);
                        Console.WriteLine("Employee Address :" + obj_Modify.emp_Address);
                        Console.WriteLine("Designation      :" + obj_Modify.emp_Designation);
                        obj_Company.Fucntion_Modify_Employee(employeeList, obj_Modify);
                        obj_Company.Function_Display_Employee(employeeList);
                    }
                    else
                    {
                        Console.WriteLine("Record Not Found...!!!");
                    }

                    break;
                case 5:
                    Console.WriteLine("Enter Employee Id Which You Want To Search:");
                    search_Id = Convert.ToInt32(Console.ReadLine());
                    AbcCmpany obj_Delete = obj_Company.Function_Search(employeeList, search_Id);
                    if (obj_Delete != null)
                    {
                        Console.WriteLine("Employee ID      :" + obj_Delete.emp_Id);
                        Console.WriteLine("Employee Name    :" + obj_Delete.emp_Name);
                        Console.WriteLine("Employee Address :" + obj_Delete.emp_Address);
                        Console.WriteLine("Designation      :" + obj_Delete.emp_Designation);
                        obj_Company.Function_Remove(employeeList, obj_Delete);
                        obj_Company.Function_Display_Employee(employeeList);
                    }
                    else
                    {
                        Console.WriteLine("Record Not Found...!!!");
                    }
                    break;
                case 6:
                    Environment.Exit(0);
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
}
