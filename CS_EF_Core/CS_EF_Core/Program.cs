using CS_EF_Core.Models;
using CS_EF_Core.DataAccess;
using System.Text.Json;



IDataAccess<Department, int> dataAccess = new DepartmentDataAccess();
IDataAccess1<Employee, int> dataAccess1 = new EmployeeDataAccess();
int a=0;
do
{
    Console.WriteLine("Enter Operation that You want to perform \n"
                       + "1.Get Data from Employee table\n" +
                       "2.Add new record in Employee Table \n" +
                       "3.Update Emp on EmpNO\n" +
                       "4.Delete Emp by EmpNo \n" +
                       "5.Get EmpInfo by EmpNo \n" +
                       "6.Get data from Department Table\n" +
                       "7.Add new record into Dept\n" +
                       "8.Update record from dept\n" +
                       "9.Delete record from dept\n" +
                       "10.Get DeptInfo by DeptNo\n"+
                       "11.Clear Screen\n" +
                       "12.Exit Program");
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            var employees = await dataAccess1.GetAsync();

            Console.WriteLine($"List of Emps:{JsonSerializer.Serialize(employees)}");
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.EmpNo}  {item.EmpName} {item.Salary} {item.Designation} {item.DeptNo} {item.Email}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

            case 2:
            Console.WriteLine("Add new Record");
            var empNew1 = new Employee();
            Console.WriteLine("enter EmpNO");
            empNew1.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter EmpName");
            empNew1.EmpName = Console.ReadLine();
            Console.WriteLine("enter Salary");
            empNew1.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Designation");
            empNew1.Designation = Console.ReadLine();
            Console.WriteLine("enter DeptNo");
            empNew1.DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Email");
            empNew1.Email = Console.ReadLine();

            var CreatEmp = await dataAccess1.CreatAsync(empNew1);
            Console.WriteLine($"Newly Added Emp" +
                $"{JsonSerializer.Serialize(CreatEmp)}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 3:
            Console.WriteLine("Updating new Record");
            var empNew = new Employee();
            Console.WriteLine("enter EmpNO");
            empNew.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter EmpName");
            empNew.EmpName = Console.ReadLine();
            Console.WriteLine("enter Salary");
            empNew.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Designation");
            empNew.Designation = Console.ReadLine();
            Console.WriteLine("enter DeptNo");
            empNew.DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Email");
            empNew.Email = Console.ReadLine();

            var UpdateEmp = await dataAccess1.UpdateAsync(empNew.EmpNo, empNew);
            Console.WriteLine($"Updated Emp" +
                $"{JsonSerializer.Serialize(UpdateEmp)}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 4:
            Console.WriteLine("enter EmpNo for delete");
            int delete1 = Convert.ToInt32(Console.ReadLine());
            var deleteEmp = await dataAccess1.DeleteAsync(delete1);
            Console.WriteLine($"Deleted Dept" +
                $"{JsonSerializer.Serialize(deleteEmp)}");
            break;

        case 5:
            Console.WriteLine("Enter EmpNo");
            bool IsNum1 = int.TryParse(Console.ReadLine(), out int num1);
            while (!IsNum1)
            {
                Console.WriteLine("Enter Valid Number");
                IsNum1 = int.TryParse(Console.ReadLine(), out num1);
            }
            var emp = await dataAccess1.GetbyId(num1);
            if (emp != null)
            {
                Console.WriteLine($"DeptNo: {emp.EmpNo} DeptName: {emp.EmpName} Location : {emp.Salary} Capacity : {emp.Designation} DeptNo : {emp.DeptNo} Email : {emp.Email}");
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }
            break;

        case 6:
            var departments = await dataAccess.GetAsync();

            Console.WriteLine($"List of depts:{JsonSerializer.Serialize(departments)}");
            foreach (var item in departments)
            {
                Console.WriteLine($"{item.DeptNo}  {item.DeptName} {item.Location} {item.Capacity}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 7:
            Console.WriteLine("Add new Record");
            var DeptNew = new Department();
            Console.WriteLine("enter DeptNo");
            DeptNew.DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter DeptName");
            DeptNew.DeptName = Console.ReadLine();
            Console.WriteLine("enter Location");
            DeptNew.Location = Console.ReadLine();
            Console.WriteLine("enter Capacity");
            DeptNew.Capacity = Convert.ToInt32(Console.ReadLine());

            var CreatDept = await dataAccess.CreatAsync(DeptNew);
            Console.WriteLine($"Newly Added Dept" +
                $"{JsonSerializer.Serialize(CreatDept)}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 8:
            Console.WriteLine("Updating new Record");
            var DeptNew1 = new Department();
            Console.WriteLine("enter DeptNo");
            DeptNew1.DeptNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter DeptName");
            DeptNew1.DeptName = Console.ReadLine();
            Console.WriteLine("enter Location");
            DeptNew1.Location = Console.ReadLine();
            Console.WriteLine("enter Capacity");
            DeptNew1.Capacity = Convert.ToInt32(Console.ReadLine());

            var UpdateDept = await dataAccess.UpdateAsync(DeptNew1.DeptNo, DeptNew1);
            Console.WriteLine($"Updated Dept" +
                $"{JsonSerializer.Serialize(UpdateDept)}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 9:
            Console.WriteLine("enter DeptNo for delete");
            int delete = Convert.ToInt32(Console.ReadLine());
            var deleteDept = await dataAccess.DeleteAsync(delete);
            Console.WriteLine($"Deleted Dept" +
                $"{JsonSerializer.Serialize(deleteDept)}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;

        case 10:
            Console.WriteLine("Enter DeptNo");
            bool IsNum = int.TryParse(Console.ReadLine(), out int num);
            while (!IsNum)
            {
                Console.WriteLine("Enter Valid Number");
                IsNum = int.TryParse(Console.ReadLine(), out num);
            }
            var dept = await dataAccess.GetbyId(num);
            if (dept != null)
            {
                Console.WriteLine($"DeptNo: {dept.DeptNo} DeptName: {dept.DeptName} Location : {dept.Location} Capacity : {dept.Capacity}");
            }
            else
            {
                Console.WriteLine("Department Not Found");
            }
            break;

        case 11:
            Console.Clear();
            break;

        case 12:
            a++;
            break;

        default:
            Console.WriteLine("Wrong Choice");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            break;
    }
} while (a == 0);

Console.ReadLine();














