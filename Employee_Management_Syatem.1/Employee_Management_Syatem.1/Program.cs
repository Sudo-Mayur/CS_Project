
using System;
using Employee_Management_System;
using System.Collections.Generic;

namespace Employee_Management_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {              
                Console.WriteLine("Welcome to Employee Management System");
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("Enter Your choice");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Display employeelist");
                Console.WriteLine("3.Delete Employee");
                Console.WriteLine("4.Search employee");
                Console.WriteLine("5.Update Employee");
                int choice = Convert.ToInt32(Console.ReadLine());
                Client client = new Client();
                switch (choice)
                {
                    case 1:
                        client.Entry("Add");
                        break;
                    case 2:
                        client.Display();
                        break;
                    case 3:
                        client.Delete();
                        break;
                    case 4:
                        client.Search();
                        break;
                    case 5:
                        client.Entry("Update");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                       
                }

            }
            while (true);
        }

    }
}