using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class Client
    {
        public EmployeeOperations opt = new EmployeeOperations();


        public bool validateEmpNo(int data)
        {
            bool search1, search2;
            search1 = opt.SearchEmployee(data, out int? index);
            search2 = data > 0;

            return !search1 && search2;
        }
        public bool validateEmpname(string name)
        {
            bool search = true;
            return search;
        }
        public void Delete()
        {
            Console.WriteLine("Enter The Employee Number");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The info will be deleted permanently press 1 to countinue 2 to go back");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    opt.DeleteEmployee(id);
                    break;
                case 2:
                    Console.WriteLine("Not deleted Going back");
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
        }
        public void Search()
        {
            Console.WriteLine("Enter The Employee Number to search");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Employee  found is {opt.SearchEmployee(id, out int? index)}");


        }
        public Employee Create(int id, string empname, string dptname, string Designation, int salary)
        {
            Employee temp = new Employee();
            temp.EmpNo = id;
            temp.EmpName = empname;
            temp.DeptName = dptname;
            temp.Designation = Designation;
            temp.Salary = salary;
            return temp;
        }
        public void Entry(string choice)
        {
            try
            {
                Console.WriteLine("Enter Employee Number");
                int Id = Convert.ToInt32(Console.ReadLine());
                if (!validateEmpNo(Id))
                {
                    throw new Exception("Employee No is not valid or may be repeated");
                }
                Console.WriteLine("Enter Employee Name");
                string name = Console.ReadLine();
                if (!validateEmpname(name))
                {
                    throw new Exception("Employee Name is not in correct format");
                }
                Console.WriteLine("Enter Choice of Department 1)IT, 2)HRD, 3)Sales, 4)Admin, 5)Account");
                string ChoiceOfDepart = Console.ReadLine();
                string DeprtName;
                switch (ChoiceOfDepart)
                {
                    case "IT":
                        DeprtName = "IT";
                        break;
                    case "HRD":
                        DeprtName = "HRD";
                        break;
                    case "Sales":
                        DeprtName = "Sales";
                        break;
                    case "Admin":
                        DeprtName = "Admin";
                        break;
                    case "Account":
                        DeprtName = "Account";
                        break;
                    default:
                        throw new Exception("Invalid Choice");

                }
                Console.WriteLine("Enter Choice of Designation 1) Manager, 2)Engineer, 3)Clerk, 4)Staff");
                string ChoiceOfDesign = Console.ReadLine();
                string desgntn;
                switch (ChoiceOfDesign)
                {
                    case "Manager":
                        desgntn = "Manager";
                        break;
                    case "Engineer":
                        desgntn = "Engineer";
                        break;
                    case "Clerk":
                        desgntn = "Clerk";
                        break;
                    case "Staff":
                        desgntn = "Staff";
                        break;
                    default:
                        throw new Exception("Invalid Choice");

                }
                Console.WriteLine("Enter Employee Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                if (salary < 0)
                {
                    throw new Exception("salary cannot be negative");
                }
                Employee emp = Create(Id, name, DeprtName, desgntn, salary);
                switch (choice)
                {
                    case "Add":
                        opt.AddEmployee(emp);
                        break;
                    case "Update":
                        Console.WriteLine("enter employee id at which you want to update this info");
                        int UpdId = Convert.ToInt32(Console.ReadLine());
                        opt.UpdateEmployee(UpdId, emp);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Display()
        {
            Console.WriteLine("Employee Data");
            Console.WriteLine("---------------------------------------------------------------");
           
                    foreach (Employee emp in opt.GetEmployees())
                    {
                        Console.WriteLine("Emptno\tEmpName\tDepartment\tDesignation\tSalary");
                        Console.WriteLine($"{emp.EmpNo}\t{emp.EmpName}\t{emp.DeptName}\t\t{emp.Designation}\t\t{emp.Salary}");
                        Console.WriteLine("---------------------------------------------------------------");
                    }

            }
        }
    }
