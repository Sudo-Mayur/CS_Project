using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    public class EmployeeOperations
    {
        static List<Employee> Employees = new List<Employee>();

       
        public List<Employee> GetEmployees()
        {
            return Employees;
        }

        public void AddEmployee(Employee emp)
        {
            Employees.Add(emp);
           
        }
        public void UpdateEmployee(int empNo, Employee UpdateInfo)
        {
            try
            {
                if (SearchEmployee(empNo, out int? Index))
                {
                    int index = (int)Index;
                    // Employees.Insert(index, UpdateInfo);
                    Employees[index] = UpdateInfo;

                }
                else
                {
                    throw new Exception("The employee Not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeleteEmployee(int id)
        {
            try
            {
                if (SearchEmployee(id, out int? Index))
                {
                    int index = (int)Index;
                    Console.WriteLine($"The Employee info is Deleted and Deleted info belongs to{ Employees[index].EmpName}");
                    Employees.RemoveAt(index);
                }
                else
                {
                    throw new Exception("The employee Not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public bool SearchEmployee(int Id, out int? index)
        {
            bool search = false;
            index = null;
            if (Employees != null)
            {
                foreach (Employee emp in Employees)
                {
                    if (emp.EmpNo == Id)
                    {
                        search = true;
                        index = Employees.IndexOf(emp);
                    }
                }
            }
            //else
            //{
            //  Console.WriteLine("The list is empty");
            //}
            return search;
        }
    }
}
