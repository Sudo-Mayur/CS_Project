using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CS_NetFrwk_ConnectedApp.Models;
using CS_NetFrwk_ConnectedApp.DataAccess;
namespace CS_NetFrwk_ConnectedApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using the ADO.NET Connected Architecture");
            //try
            //{
                IDataAccess<Employee, int> empdata = new EmplyeeDataAccess();
            do
            {
                Console.WriteLine("Enter Operation that You want to perform \n" +
               "1.Get Data \n" + "2.Print data on EmpNo\n" + "3.Updating records \n" + "4.Delete Records");
                Console.WriteLine("-------------------------------------------------------------------------------------------");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        var employees = empdata.GetData();
                        Console.WriteLine("EmpNo  EmpName  salary  Designation DeptNo Email");
                        foreach (Employee dept in employees)
                        {
                            Console.WriteLine($"{dept.EmpNo}   {dept.EmpName} {dept.salary} {dept.Designation} {dept.DeptNo}  {dept.Email}");
                        }
                        Console.WriteLine("-------------------------------------------------------------------------------------------");

                        break;


                    case 2:
                        Console.WriteLine("Print Record based on the EmpNo ");
                        Console.WriteLine("Enter EmpNo");
                        var emp1 = empdata.GetData(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("EmpNo EmpName  salary  Designation  DeptNo Email");
                        Console.WriteLine($"{emp1.EmpNo}  {emp1.EmpName} {emp1.salary} {emp1.Designation} {emp1.DeptNo}  {emp1.Email}");

                        Console.WriteLine("-------------------------------------------------------------------------------------------");

                        break;


                    case 3:
                        Console.WriteLine("Updating new Record");
                        Console.WriteLine("Enter EmpNo\n"+"Enter EmpName\n"+"Enter salary\n" + "Enter Designatioin\n" + "Enter DeptNo\n" +"Enter Email\n");
                        var empNew = new Employee()
                        { 
                        EmpNo = Convert.ToInt32(Console.ReadLine()),
                        EmpName = Console.ReadLine(),
                        salary = Convert.ToInt32(Console.ReadLine()),
                        Designation = Console.ReadLine(),
                        DeptNo = Convert.ToInt32(Console.ReadLine()),
                        Email = Console.ReadLine(),
                        };

                        Console.WriteLine(" Enter EmpNo on which you are performing Update operation");
                        int EmpNo = Convert.ToInt32(Console.ReadLine());
                        var result = empdata.Update(EmpNo, empNew);

                        if (result == null)
                        {
                            Console.WriteLine("Upate Faild");
                        }
                        else
                        {
                            Console.WriteLine("Update Success");
                        }

                        Console.WriteLine("-------------------------------------------------------------------------------------------");

                        break;

                    case 4:

                        Console.WriteLine("Call for delete");
                        Console.WriteLine("Enter EmpNo");
                        int EmpNo1=Convert.ToInt32(Console.ReadLine());
                        var resDelete = empdata.Delete(EmpNo1);

                        Console.WriteLine("Data After Deleting the record");
                        var emp2 = empdata.GetData(EmpNo1);

                        Console.WriteLine($"{emp2.EmpNo}  {emp2.EmpName} {emp2.salary} {emp2.Designation} {emp2.DeptNo}  {emp2.Email}");

                        Console.WriteLine("-------------------------------------------------------------------------------------------");

                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while(true);



            Console.ReadLine();


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error Occured {ex.Message}");
            //}

        }

    }
}