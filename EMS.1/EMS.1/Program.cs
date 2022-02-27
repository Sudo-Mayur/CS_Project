using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Employee_Management_System
{
    public class Employee
    {
        private int id;
        public int emp_Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string emp_Name
        {
            get { return name; }
            set { name = value; }
        }
        private string Dept;
        public string emp_Dept
        {
            get { return Dept; }
            set { Dept = value; }

        }
        private string Desigation;
        public string emp_Designation
        {
            get { return Desigation; }
            set { Desigation = value; }
        }
        private int Salary;
        public int emp_salary
        {
            get { return Salary; }
            set { Salary = value; }
        }


    }
    class EmployeeOperation
    {

        List<Employee> employeeList = new List<Employee>();

        public void Function_Add_Employee(List<Employee> employeeList)
        {
            try
            {
                Employee obj_Comapny1 = new Employee();
                Console.Write("Enter Employee Id:");
                obj_Comapny1.emp_Id = Convert.ToInt32(Console.ReadLine());
                if (obj_Comapny1.emp_Id <= 0)
                {
                    throw new Exception("Id must br greater then 0");
                }
                Console.Write("Enter Employee Name:");
                obj_Comapny1.emp_Name = Console.ReadLine();
                Console.Write("Enter Employee Department:");
                obj_Comapny1.emp_Dept = Console.ReadLine();
                Console.Write("Enter Employee Designation:");
                obj_Comapny1.emp_Designation = Console.ReadLine();
                Console.Write("Enter Employee Salary:");
                obj_Comapny1.emp_salary = Convert.ToInt32(Console.ReadLine());



                employeeList.Add(obj_Comapny1);
                Console.WriteLine("Employee Deatil Added Successfully...!!!!:");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
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


        public class Client
        {
            public static void Main(string[] args)
            {
                EmployeeOperation obj_Company = new EmployeeOperation();
                List<Employee> emp = new List<Employee>();

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
                            Console.WriteLine("Enter Employee Id Which You Want To Search and Modify:");
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
}
