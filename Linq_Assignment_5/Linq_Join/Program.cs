using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("* Using join using Imperative LINQ");
            UseJoinImperative();


            static void UseJoinImperative()
            {

                var Employees = new List<Employee>()
                {
                    new Employee() { EmpID = 1, EmpName = "Mayur", DeptNo = 1, Designation = "Manager", Empsalary = 20000 },
                    new Employee() { EmpID = 2, EmpName = "Mandar",  DeptNo =2 , Designation = "CEO", Empsalary = 12000 },
                    new Employee() { EmpID = 3, EmpName = "Sam",  DeptNo =3 , Designation = "Manager", Empsalary = 30000 },
                    new Employee() { EmpID = 4, EmpName = "Manoj",  DeptNo =4, Designation = "Intern", Empsalary = 18000 },
                    new Employee() { EmpID = 5, EmpName = "ankit",  DeptNo= 5, Designation = "Admin", Empsalary = 25000 },
                    new Employee() { EmpID = 6, EmpName = "samir", DeptNo =6 , Designation = "CTO", Empsalary = 27000 },
                    new Employee() { EmpID = 7, EmpName = "yash", DeptNo = 7, Designation = "Manager", Empsalary = 85000 },
                    new Employee() { EmpID = 8, EmpName = "Suyog",  DeptNo = 8, Designation = "Director", Empsalary = 35000 },
                    new Employee() { EmpID = 9, EmpName = "Ram",  DeptNo =9, Designation = "Intern", Empsalary = 75000 },
                    new Employee() { EmpID=  10, EmpName="Tejas",      DeptNo=10, Designation= "Manager", Empsalary=80000},
                    new Employee() { EmpID = 11, EmpName = "Shubham",  DeptNo =11, Designation = "Director", Empsalary = 50000 },
                    new Employee() { EmpID = 12, EmpName = "Rakesh",  DeptNo =12 , Designation = "Manager", Empsalary = 57000 },
                    new Employee() { EmpID = 13, EmpName = "Pavan", DeptNo =13, Designation = "CEO", Empsalary = 10000 },
                    new Employee() { EmpID = 14, EmpName = "karam",  DeptNo=14 , Designation = "Director", Empsalary = 16000 },
                    new Employee() { EmpID = 15, EmpName = "Ani",  DeptNo = 15, Designation = "Manager", Empsalary = 11000 },
                    new Employee() { EmpID = 16, EmpName = "Ankita",  DeptNo =16,  Designation = "Director", Empsalary = 10000 },
                    new Employee() { EmpID = 17, EmpName = "Rutuja", DeptNo = 17, Designation = "CEO", Empsalary = 10000 },
                    new Employee() { EmpID = 18, EmpName = "Saif",  DeptNo =18 , Designation = "Manager", Empsalary = 10000 },
                    new Employee() { EmpID = 19, EmpName = "Samar", DeptNo =19 , Designation = "Director", Empsalary = 10000 },
                    new Employee() { EmpID = 20, EmpName = "Shyam", DeptNo = 20, Designation = "Manager", Empsalary = 65000 },
                    new Employee() { EmpID = 21, EmpName = "Sunil", DeptNo = 21, Designation = "CTO", Empsalary = 55000 },
                    new Employee() { EmpID = 22, EmpName = "Mahadev",  DeptNo = 22, Designation = "Admin", Empsalary = 13000 },
                    new Employee() { EmpID = 23, EmpName = "Rahul", DeptNo =23 , Designation = "Director", Empsalary = 65000 },
                    new Employee() { EmpID = 24, EmpName = "Laxman",  DeptNo =24 , Designation = "Manager", Empsalary = 20000 },
                    new Employee() { EmpID = 25, EmpName = "Mandar",  DeptNo = 25, Designation = "CEO", Empsalary = 12000 },
                    new Employee() { EmpID = 26, EmpName = "Sam",  DeptNo= 26, Designation = "Manager", Empsalary = 30000 },
                    new Employee() { EmpID = 27, EmpName = "Manoj",  DeptNo =27 , Designation = "Intern", Empsalary = 18000 },
                    new Employee() { EmpID = 28, EmpName = "ankit",  DeptNo = 28, Designation = "Admin", Empsalary = 25000 },
                    new Employee() { EmpID = 29, EmpName = "samir",  DeptNo =29 , Designation = "CTO", Empsalary = 27000 },
                    new Employee() { EmpID = 30, EmpName = "yash", DeptNo =30, Designation = "Manager", Empsalary = 85000 },
                    new Employee() { EmpID = 31, EmpName = "Suyog",  DeptNo = 31, Designation = "Director", Empsalary = 35000 },
                    new Employee() { EmpID = 32, EmpName = "Ram",  DeptNo = 32, Designation = "Intern", Empsalary = 75000 },
                    new Employee() { EmpID = 33, EmpName = "Tejas",  DeptNo =33 , Designation = "Manager", Empsalary = 80000 },
                    new Employee() { EmpID = 34, EmpName = "Shubham",  DeptNo = 34, Designation = "Director", Empsalary = 50000 },
                    new Employee() { EmpID = 35, EmpName = "Rakesh",  DeptNo=35 , Designation = "Manager", Empsalary = 57000 },
                    new Employee() { EmpID = 36, EmpName = "Pavan",  DeptNo = 36, Designation = "CEO", Empsalary = 10000 },
                    new Employee() { EmpID = 37, EmpName = "karam",  DeptNo =37, Designation = "Director", Empsalary = 16000 },
                    new Employee() { EmpID = 38, EmpName = "Tamanna", DeptNo =38 , Designation = "Manager", Empsalary = 11000 },
                    new Employee() { EmpID = 39, EmpName = "Anita",  DeptNo =39 , Designation = "Director", Empsalary = 10000 },
                    new Employee() { EmpID = 40, EmpName = "Rutuja",  DeptNo =40, Designation = "CEO", Empsalary = 10000 },
                    new Employee() { EmpID = 41, EmpName = "Saif",  DeptNo = 41, Designation = "Manager", Empsalary = 10000 },
                    new Employee() { EmpID = 42, EmpName = "Samar",  DeptNo = 42, Designation = "Director", Empsalary = 10000 },
                    new Employee() { EmpID = 43, EmpName = "Shyam",  DeptNo =43 , Designation = "Manager", Empsalary = 65000 },
                    new Employee() { EmpID = 44, EmpName = "Mayuri",  DeptNo = 44, Designation = "CTO", Empsalary = 55000 },
                    new Employee() { EmpID = 45, EmpName = "Mahadev", DeptNo = 45, Designation = "Admin", Empsalary = 13000 },
                    new Employee() { EmpID = 46, EmpName = "Rahul", DeptNo =46 , Designation = "Director", Empsalary = 65000 },
                    new Employee() { EmpID = 47, EmpName = "Suyog", DeptNo =47 , Designation = "Director", Empsalary = 35000 },
                    new Employee() { EmpID = 48, EmpName = "Ram",  DeptNo = 48, Designation = "Intern", Empsalary = 75000 },
                    new Employee() { EmpID = 49, EmpName = "Taimur", DeptNo = 49, Designation = "Manager", Empsalary = 80000 },
                    new Employee() { EmpID = 50, EmpName = "Shubham",  DeptNo =50 , Designation = "Director", Empsalary = 50000 }
                };


                var Departments = new List<Department>()
                {
                  new Department() { DeptNo = 1, DeptName = "SL", Location = "Mumbai", Capacity = 15 },
                   new Department() { DeptNo = 2, DeptName = "IT", Location = "Thane", Capacity = 30 },
                  new Department() { DeptNo = 3, DeptName = "Account", Location = "Banglore", Capacity = 10 },
                  new Department() { DeptNo = 4, DeptName = "Admin", Location = "Ratnagiri", Capacity = 10 },
                  new Department() { DeptNo = 5, DeptName = "SL", Location = "Chennai", Capacity = 35 },
                  new Department() { DeptNo = 6, DeptName = "IT", Location = "Mumbai", Capacity = 50 },
                  new Department() { DeptNo = 7, DeptName = "HR", Location = "Hyderabad", Capacity = 10 },
                  new Department() { DeptNo = 8, DeptName = "account", Location = "Pune", Capacity = 11 },
                  new Department() { DeptNo = 9, DeptName = "HR", Location = "Chennai", Capacity = 18 },
                  new Department() { DeptNo = 10, DeptName = "Admin", Location = "Delhi", Capacity = 8 }
            };

                var join = from s in Employees
                           join s1 in Departments
                           on s.DeptNo equals s1.DeptNo
                           select new
                           {
                               EmpID = s.EmpID,
                               EmpName = s.EmpName,
                               Designation = s.Designation,
                               Location = s1.Location,
                               Empsalary = s.Empsalary
                           };
                foreach (var record in join)
                {
                    Console.WriteLine($"{record.EmpID}  {record.EmpName}  {record.Designation}  {record.Location}  {record.Empsalary}");
                }

            }
        }
    }
    internal class Employee
    {
        //EmpNo, EmpName, DeptName, Salary, Designation
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int DeptNo { get; set; }
        public int Empsalary { get; set; }
        public string Designation { get; set; }


    }

    internal class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }


    }


}
