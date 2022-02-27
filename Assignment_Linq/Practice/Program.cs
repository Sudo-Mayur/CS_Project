using System;
using System.Collections.Generic;

namespace Practice
{
    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpID = 1, EmpName = "Mayur", DeptName = "HR", Designation = "Manager", Empsalary = 20000 });
            Add(new Employee() { EmpID = 2, EmpName = "Mandar", DeptName = "RND", Designation = "CEO", Empsalary = 12000 });
            Add(new Employee() { EmpID = 3, EmpName = "Sam", DeptName = "Sales", Designation = "Manager", Empsalary = 30000 });
            Add(new Employee() { EmpID = 4, EmpName = "Manoj", DeptName = "Marketing", Designation = "Intern", Empsalary = 18000 });
            Add(new Employee() { EmpID = 5, EmpName = "ankit", DeptName = "Operations", Designation = "Admin", Empsalary = 25000 });
            Add(new Employee() { EmpID = 6, EmpName = "samir", DeptName = "Purchase", Designation = "CTO", Empsalary = 27000 });
            Add(new Employee() { EmpID = 7, EmpName = "yash", DeptName = "Finance", Designation = "Manager", Empsalary = 85000 });
            Add(new Employee() { EmpID = 8, EmpName = "Suyog", DeptName = "Management", Designation = "Director", Empsalary = 35000 });
            Add(new Employee() { EmpID = 9, EmpName = "Ram", DeptName = "HR", Designation = "Intern", Empsalary = 75000 });
            Add(new Employee() { EmpID = 10, EmpName = "Tejas", DeptName = "Sales", Designation = "Manager", Empsalary = 80000 });
            Add(new Employee() { EmpID = 11, EmpName = "Shubham", DeptName = "Marketing", Designation = "Director", Empsalary = 50000 });
            Add(new Employee() { EmpID = 12, EmpName = "Rakesh", DeptName = "Purchase", Designation = "Manager", Empsalary = 57000 });
            Add(new Employee() { EmpID = 13, EmpName = "Pavan", DeptName = "Finance", Designation = "CEO", Empsalary = 10000 });
            Add(new Employee() { EmpID = 14, EmpName = "karam", DeptName = "HR", Designation = "Director", Empsalary = 16000 });
            Add(new Employee() { EmpID = 15, EmpName = "Ani", DeptName = "Sales", Designation = "Manager", Empsalary = 11000 });
            Add(new Employee() { EmpID = 16, EmpName = "Ankita", DeptName = "Finance", Designation = "Director", Empsalary = 10000 });
            Add(new Employee() { EmpID = 17, EmpName = "Rutuja", DeptName = "RND", Designation = "CEO", Empsalary = 10000 });
            Add(new Employee() { EmpID = 18, EmpName = "Saif", DeptName = "Management", Designation = "Manager", Empsalary = 10000 });
            Add(new Employee() { EmpID = 19, EmpName = "Samar", DeptName = "Purchase", Designation = "Director", Empsalary = 10000 });
            Add(new Employee() { EmpID = 20, EmpName = "Shyam", DeptName = "Operations", Designation = "Manager", Empsalary = 65000 });
            Add(new Employee() { EmpID = 21, EmpName = "Sunil", DeptName = "HR", Designation = "CTO", Empsalary = 55000 });
            Add(new Employee() { EmpID = 22, EmpName = "Mahadev", DeptName = "Sales", Designation = "Admin", Empsalary = 13000 });
            Add(new Employee() { EmpID = 23, EmpName = "Rahul", DeptName = "RND", Designation = "Director", Empsalary = 65000 });
            Add(new Employee() { EmpID = 24, EmpName = "Laxman", DeptName = "HR", Designation = "Manager", Empsalary = 20000 });
            Add(new Employee() { EmpID = 25, EmpName = "Mandar", DeptName = "RND", Designation = "CEO", Empsalary = 12000 });
            Add(new Employee() { EmpID = 26, EmpName = "Sam", DeptName = "Sales", Designation = "Manager", Empsalary = 30000 });
            Add(new Employee() { EmpID = 27, EmpName = "Manoj", DeptName = "Marketing", Designation = "Intern", Empsalary = 18000 });
            Add(new Employee() { EmpID = 28, EmpName = "ankit", DeptName = "Operations", Designation = "Admin", Empsalary = 25000 });
            Add(new Employee() { EmpID = 29, EmpName = "samir", DeptName = "Purchase", Designation = "CTO", Empsalary = 27000 });
            Add(new Employee() { EmpID = 30, EmpName = "yash", DeptName = "Finance", Designation = "Manager", Empsalary = 85000 });
            Add(new Employee() { EmpID = 31, EmpName = "Suyog", DeptName = "Management", Designation = "Director", Empsalary = 35000 });
            Add(new Employee() { EmpID = 32, EmpName = "Ram", DeptName = "HR", Designation = "Intern", Empsalary = 75000 });
            Add(new Employee() { EmpID = 33, EmpName = "Tejas", DeptName = "Sales", Designation = "Manager", Empsalary = 80000 });
            Add(new Employee() { EmpID = 34, EmpName = "Shubham", DeptName = "Marketing", Designation = "Director", Empsalary = 50000 });
            Add(new Employee() { EmpID = 35, EmpName = "Rakesh", DeptName = "Purchase", Designation = "Manager", Empsalary = 57000 });
            Add(new Employee() { EmpID = 36, EmpName = "Pavan", DeptName = "Finance", Designation = "CEO", Empsalary = 10000 });
            Add(new Employee() { EmpID = 37, EmpName = "karam", DeptName = "HR", Designation = "Director", Empsalary = 16000 });
            Add(new Employee() { EmpID = 38, EmpName = "Tamanna", DeptName = "Sales", Designation = "Manager", Empsalary = 11000 });
            Add(new Employee() { EmpID = 39, EmpName = "Anita", DeptName = "Finance", Designation = "Director", Empsalary = 10000 });
            Add(new Employee() { EmpID = 40, EmpName = "Rutuja", DeptName = "RND", Designation = "CEO", Empsalary = 10000 });
            Add(new Employee() { EmpID = 41, EmpName = "Saif", DeptName = "Management", Designation = "Manager", Empsalary = 10000 });
            Add(new Employee() { EmpID = 42, EmpName = "Samar", DeptName = "Purchase", Designation = "Director", Empsalary = 10000 });
            Add(new Employee() { EmpID = 43, EmpName = "Shyam", DeptName = "Operations", Designation = "Manager", Empsalary = 65000 });
            Add(new Employee() { EmpID = 44, EmpName = "Mayuri", DeptName = "HR", Designation = "CTO", Empsalary = 55000 });
            Add(new Employee() { EmpID = 45, EmpName = "Mahadev", DeptName = "Sales", Designation = "Admin", Empsalary = 13000 });
            Add(new Employee() { EmpID = 46, EmpName = "Rahul", DeptName = "RND", Designation = "Director", Empsalary = 65000 });
            Add(new Employee() { EmpID = 47, EmpName = "Suyog", DeptName = "Management", Designation = "Director", Empsalary = 35000 });
            Add(new Employee() { EmpID = 48, EmpName = "Ram", DeptName = "HR", Designation = "Intern", Empsalary = 75000 });
            Add(new Employee() { EmpID = 49, EmpName = "Taimur", DeptName = "Sales", Designation = "Manager", Empsalary = 80000 });
            Add(new Employee() { EmpID = 50, EmpName = "Shubham", DeptName = "Marketing", Designation = "Director", Empsalary = 50000 });

        }
       
    }
}
