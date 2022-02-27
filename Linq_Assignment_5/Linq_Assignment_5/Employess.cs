using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "Sumit", DeptName = "IT", Salary = 110000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 2, EmpName = "Keshav", DeptName = "HR", Salary = 120000, Designation = "Director" });
            Add(new Employee() { EmpNo = 3, EmpName = "Ram", DeptName = "SL", Salary = 130000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 4, EmpName = "Anil", DeptName = "IT", Salary = 140000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 5, EmpName = "Jaywant", DeptName = "HR", Salary = 100000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 6, EmpName = "Abhay", DeptName = "SL", Salary = 75000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 7, EmpName = "Anil", DeptName = "IT", Salary = 80000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 8, EmpName = "Shyam", DeptName = "HR", Salary = 70000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 9, EmpName = "Vikram", DeptName = "SL", Salary = 60000, Designation = "Director" });
            Add(new Employee() { EmpNo = 10, EmpName = "Anand", DeptName = "IT", Salary = 50000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 11, EmpName = "Yash", DeptName = "IT", Salary = 10000, Designation = "Director" });
            Add(new Employee() { EmpNo = 12, EmpName = "Mayur", DeptName = "HR", Salary = 12000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 13, EmpName = "Suyog", DeptName = "SL", Salary = 13000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 14, EmpName = "Sam", DeptName = "IT", Salary = 15000, Designation = "Director" });
            Add(new Employee() { EmpNo = 15, EmpName = "Sasi", DeptName = "HR", Salary = 11000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 16, EmpName = "Ayush", DeptName = "SL", Salary = 29000, Designation = "Director" });
            Add(new Employee() { EmpNo = 17, EmpName = "Onkar", DeptName = "IT", Salary = 28000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 18, EmpName = "Laxman", DeptName = "HR", Salary = 37000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 19, EmpName = "Ankita", DeptName = "SL", Salary = 46000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 20, EmpName = "Jahanvi", DeptName = "IT", Salary = 65000, Designation = "Director" });
            Add(new Employee() { EmpNo = 21, EmpName = "Chitra", DeptName = "IT", Salary = 81000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 22, EmpName = "Manas", DeptName = "HR", Salary = 92000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 23, EmpName = "Satyam", DeptName = "SL", Salary = 13000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 24, EmpName = "Shreyash", DeptName = "IT", Salary = 14000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 25, EmpName = "Kshitij", DeptName = "HR", Salary = 40000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 26, EmpName = "Shashank", DeptName = "SL", Salary = 8000, Designation = "Director" });
            Add(new Employee() { EmpNo = 27, EmpName = "Tanmay", DeptName = "IT", Salary = 98000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 28, EmpName = "Sahil", DeptName = "HR", Salary = 75000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 29, EmpName = "Labhesh", DeptName = "SL", Salary = 66000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 30, EmpName = "Shreya", DeptName = "IT", Salary = 55000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 31, EmpName = "Varad", DeptName = "IT", Salary = 19000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 32, EmpName = "Gaurav", DeptName = "HR", Salary = 22000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 33, EmpName = "Athul", DeptName = "SL", Salary = 23000, Designation = "Director" });
            Add(new Employee() { EmpNo = 34, EmpName = "Paras", DeptName = "IT", Salary = 74000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 35, EmpName = "Vishakha", DeptName = "HR", Salary = 20000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 36, EmpName = "Aarohi", DeptName = "SL", Salary = 92000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 37, EmpName = "Vaishnavi", DeptName = "IT", Salary = 28000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 38, EmpName = "Gauri", DeptName = "HR", Salary = 37000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 39, EmpName = "Srushti", DeptName = "SL", Salary = 46000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 40, EmpName = "Harsh", DeptName = "IT", Salary = 57000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 41, EmpName = "Deepak", DeptName = "IT", Salary = 41000, Designation = "Director" });
            Add(new Employee() { EmpNo = 42, EmpName = "Chaitanya", DeptName = "HR", Salary = 2000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 43, EmpName = "Manasi", DeptName = "SL", Salary = 63000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 44, EmpName = "Varun", DeptName = "IT", Salary = 94000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 45, EmpName = "Raghav", DeptName = "HR", Salary = 10000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 46, EmpName = "Akshada", DeptName = "SL", Salary = 9000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 47, EmpName = "Rahul", DeptName = "IT", Salary = 8000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 48, EmpName = "Suraj", DeptName = "HR", Salary = 70600, Designation = "Manager" });
            Add(new Employee() { EmpNo = 49, EmpName = "Samir", DeptName = "SL", Salary = 60800, Designation = "Employee" });
            Add(new Employee() { EmpNo = 50, EmpName = "Shubham", DeptName = "IT", Salary = 55000, Designation = "Director" });
        }

    }
}