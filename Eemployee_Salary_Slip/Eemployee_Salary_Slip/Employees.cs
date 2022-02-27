using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_Slip
{
    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "Sumit", DeptName = "IT", Salary = 75000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 2, EmpName = "Mandar", DeptName = "HR", Salary = 90000, Designation = "Director" });
            Add(new Employee() { EmpNo = 3, EmpName = "Ram", DeptName = "SL", Salary = 50000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 4, EmpName = "Ragini", DeptName = "IT", Salary = 160000, Designation = "Director" });
            Add(new Employee() { EmpNo = 5, EmpName = "Karan", DeptName = "HR", Salary = 750000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 6, EmpName = "Prasad", DeptName = "SL", Salary = 30000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 7, EmpName = "Anil", DeptName = "IT", Salary = 55000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 8, EmpName = "Suhas", DeptName = "HR", Salary = 36000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 9, EmpName = "Vikram", DeptName = "SL", Salary = 85000, Designation = "Director" });
            Add(new Employee() { EmpNo = 10, EmpName = "Anand", DeptName = "IT", Salary = 42000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 11, EmpName = "Yash", DeptName = "IT", Salary = 65000, Designation = "Director" });
            Add(new Employee() { EmpNo = 12, EmpName = "Mayur", DeptName = "HR", Salary = 30000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 13, EmpName = "Suyog", DeptName = "SL", Salary = 20000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 14, EmpName = "Sam", DeptName = "IT", Salary = 150000, Designation = "Director" });
            Add(new Employee() { EmpNo = 15, EmpName = "Sasi", DeptName = "HR", Salary = 35000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 16, EmpName = "Ayush", DeptName = "SL", Salary = 120000, Designation = "Director" });
            Add(new Employee() { EmpNo = 17, EmpName = "Onkar", DeptName = "IT", Salary = 70000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 18, EmpName = "Laxman", DeptName = "HR", Salary = 360000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 19, EmpName = "Ankita", DeptName = "SL", Salary = 41000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 20, EmpName = "Jahanvi", DeptName = "IT", Salary = 155000, Designation = "Director" });
            Add(new Employee() { EmpNo = 21, EmpName = "Dipali", DeptName = "IT", Salary = 45000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 22, EmpName = "Paras", DeptName = "HR", Salary = 89000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 23, EmpName = "Radhika", DeptName = "SL", Salary = 13000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 24, EmpName = "Shreyash", DeptName = "IT", Salary = 9000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 25, EmpName = "Manoj", DeptName = "HR", Salary = 35000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 26, EmpName = "Shashank", DeptName = "SL", Salary = 140000, Designation = "Director" });
            Add(new Employee() { EmpNo = 27, EmpName = "Tanmay", DeptName = "IT", Salary = 66000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 28, EmpName = "Sahil", DeptName = "HR", Salary = 15000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 29, EmpName = "Labhesh", DeptName = "SL", Salary =15000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 30, EmpName = "Shreya", DeptName = "IT", Salary = 50000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 31, EmpName = "Varad", DeptName = "IT", Salary = 1500, Designation = "Employee" });
            Add(new Employee() { EmpNo = 32, EmpName = "Gaurav", DeptName = "HR", Salary = 11000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 33, EmpName = "Anket", DeptName = "SL", Salary = 120000, Designation = "Director" });
            Add(new Employee() { EmpNo = 34, EmpName = "Paras", DeptName = "IT", Salary = 49000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 35, EmpName = "Vishakha", DeptName = "HR", Salary = 124000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 36, EmpName = "Aarohi", DeptName = "SL", Salary = 3000000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 37, EmpName = "Vaishnavi", DeptName = "IT", Salary = 950000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 38, EmpName = "Nayan", DeptName = "HR", Salary = 350000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 39, EmpName = "Srushti", DeptName = "SL", Salary = 460000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 40, EmpName = "Harsh", DeptName = "IT", Salary = 550000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 41, EmpName = "Deepak", DeptName = "IT", Salary = 650000, Designation = "Director" });
            Add(new Employee() { EmpNo = 42, EmpName = "Chaitanya", DeptName = "HR", Salary = 2400000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 43, EmpName = "Manasi", DeptName = "SL", Salary = 650000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 44, EmpName = "Varun", DeptName = "IT", Salary = 390000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 45, EmpName = "Raghav", DeptName = "HR", Salary = 310000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 46, EmpName = "Akshada", DeptName = "SL", Salary = 2000000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 47, EmpName = "Rahul", DeptName = "IT", Salary = 375000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 48, EmpName = "Suraj", DeptName = "HR", Salary = 2100000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 49, EmpName = "Samir", DeptName = "SL", Salary = 35000, Designation = "Employee" });
            Add(new Employee() { EmpNo = 50, EmpName = "Prathamesh", DeptName = "IT", Salary = 130000, Designation = "Director" });
        }

    }
}