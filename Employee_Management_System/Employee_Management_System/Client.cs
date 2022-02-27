using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class Client
    {
        public static void Main(string[]args)
        {
            EmployeeOperation obj_Company = new EmployeeOperation();
            List<Employee>emp=new List<Employee>();

            char ans;
            int search_Id;
            do
            {
                //Console.Clear();
                Console.WriteLine("**************************EMPLOYEE MANAGEMENT SYSTEM ******************************");
                Console.WriteLine("1. Add  an Employee");
                Console.WriteLine("2. View Employee details");
                Console.WriteLine("3. Search Employee details");
                Console.WriteLine("4. Update Employee details");
                Console.WriteLine("5. Remove Employee details");

                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.Write("Enter Your Choise Here:-");
                int choose_number = Convert.ToInt32(Console.ReadLine());

                switch (choose_number)
                {
                    case 1:
                        obj_Company.Function_Add_Employee(emp);
                        //obj_Company.Function_Display_Employee(emp);
                        break;
                    case 2:
                        obj_Company.Function_Display_Employee(emp);
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee Id Which You Want To Search:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Employee obj_search = obj_Company.Function_Search(emp, search_Id);
                        if (obj_search != null)
                        {
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("Employee Id\tEmployee Name\tEmployee Department\tEmployee Designation\tEmployee Salary");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine(obj_search.emp_Id + "      \t|  " + obj_search.emp_Name + " \t| " + obj_search.emp_Dept + "   \t\t\t|  " + obj_search.emp_Designation + "    \t \t|  " + obj_search.emp_salary);
   
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
     
                        }
                        else
                        {
                            Console.WriteLine("Employee not found in record"); 
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee Id Which You Want To Search and Update:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Employee obj_Modify = obj_Company.Function_Search(emp, search_Id);
                        if (obj_Modify != null)
                        {
                            Console.WriteLine("Employee ID      :" + obj_Modify.emp_Id);
                            Console.WriteLine("Employee Name    :" + obj_Modify.emp_Name);
                            Console.WriteLine("Employee Address :" + obj_Modify.emp_Dept);
                            Console.WriteLine("Designation      :" + obj_Modify.emp_Designation);
                            Console.WriteLine("Employee salary  :" + obj_Modify.emp_salary);
                            obj_Company.Fucntion_Update_Employee(emp, obj_Modify);
                            obj_Company.Function_Display_Employee(emp);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Employee Id Which You Want To Search and Remove:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Employee obj_Delete = obj_Company.Function_Search(emp, search_Id);
                        if (obj_Delete != null)
                        {
                            Console.WriteLine("Employee ID      :" + obj_Delete.emp_Id);
                            Console.WriteLine("Employee Name    :" + obj_Delete.emp_Name);
                            Console.WriteLine("Employee Address :" + obj_Delete.emp_Dept);
                            Console.WriteLine("Designation      :" + obj_Delete.emp_Designation);
                            Console.WriteLine("Employee Salary  :" + obj_Delete.emp_salary);
                            obj_Company.Function_Remove(emp, obj_Delete);
                            obj_Company.Function_Display_Employee(emp);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }
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

