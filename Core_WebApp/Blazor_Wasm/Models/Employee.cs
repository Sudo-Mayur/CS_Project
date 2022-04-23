namespace Blazor_Wasm.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Designation { get; set; }
        public string? DeptName { get; set; }
        public int Salary { get; set; }


        public class EmployeeDB : List<Employee>
        {
            public EmployeeDB()
            {
                Add(new Employee() { EmpNo = 1, EmpName = "Mayur", Designation = "Manager", DeptName = "IT", Salary = 2000 });
                Add(new Employee() { EmpNo = 1, EmpName = "Yash", Designation = "Manager", DeptName = "IT", Salary = 2000 });
            }

        }
    }
}






