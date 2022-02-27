using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Users\Coditas\Desktop\Dotnet Training Assignments and mini projects\SalarySlip";
            DirectoryOperations directoryOperations = new DirectoryOperations();
            List<string> filestore = new List<string>();
            filestore = directoryOperations.storeFile(dirName);
            do
            {
                Console.WriteLine("\nWhat you wanna do today\n" +
                                  "1.Print all files having an extension as .txt\n" +
                                  "2.read all data from file\n" +
                                  "3.read a Single Line from the file\n" +
                                  "4.Read data by entering the Line Number\n" +
                                  "5.Exit");
                int ans = int.Parse(Console.ReadLine());
                switch (ans)
                {

                    case 1:

                        directoryOperations.printFile(filestore);
                        break;

                    case 2:


                        directoryOperations.printFile(filestore);
                        Console.WriteLine("Enter the file name from above list whose content you want to read");
                        string wholeFile = Console.ReadLine();
                        directoryOperations.ReadFromFile(dirName, wholeFile);
                        break;

                    case 3:

                        directoryOperations.printFile(filestore);
                        Console.WriteLine("Enter the file name from above list whose content you want to read");
                        string singleLineRead = Console.ReadLine();
                        directoryOperations.ReadFromFileSingle(dirName, singleLineRead);
                        break;

                    case 4:

                        directoryOperations.printFile(filestore);
                        Console.WriteLine("Enter the file name from above list whose content you want to read");
                        string userLine = Console.ReadLine();


                        break;

                    default:
                        Console.WriteLine("Invalid choice...try again!");
                        break;
                }
            }
            while (true);
        }
    }
}
