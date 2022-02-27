using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CS_NetFrwk_Disconnected;
using CS_NetFrwk_Disconnected.DataAccess;


namespace CS_NetFrwk_Disconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADO.NET Disconnected Architecture");

            IDataAccess<Department> deptDA = new DepartmentDataAccess();
            IDataAccess<Employee> deptDA1 = new EmployeeDataAccess();
             int a=0;
            do
            {
                Console.WriteLine("Enter your choice\n" + "1.GetData from Department table\n" + "2.Add new Record in Daprtment table\n" + "3.Update record from Department table\n" +
                    "4.Delete record from Department Table\n\n" + "5.GetData from Employee table\n" + "6.Add new Record in Employee Table\n" + "7.Update record from Employee Table\n" +
                    "8.Delete record from Employee Table\n" +"9.Exit Program");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        deptDA.GetData();
                        break;

                    case 2:
                        deptDA.Create();
                        break;

                    case 3:
                        deptDA.Update();
                        break;

                    case 4:
                        deptDA.Delete();
                        break;

                     case 5: 
                            deptDA1.GetData();
                        break;

                     case 6:
                        deptDA1.Create();
                        break;

                     case 7:
                             deptDA1.Update();
                        break;

                    case 8:
                        deptDA1.Delete();
                        break;

                    case 9:
                        a++;
                        break;
                            



                    default:
                        Console.WriteLine("Wrong Input Choice");
                        break;


                }
            } while (a==0);


          


        }

    }
}