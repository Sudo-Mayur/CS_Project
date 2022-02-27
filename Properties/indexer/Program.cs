using System;

namespace indexer
{
    internal class Program
    {
        private int[] Age = new int[4];     
        public int this[int index]
        {
            set
            {
                if (index >= 0 && index < Age.Length)
                {
                    if (value > 0)
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Value.....");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Index.....");
                }
            }
            get
            {
                return Age[index];
            }
        }
    }
    class Employee
    {
        public static void Main(string[]args)
        {
            Program emp = new Program();
            emp[0]= 21;
            Console.WriteLine(emp[0]);
            emp[1] = 23;
            Console.WriteLine(emp[1]);
            emp[6] = 25;
            emp[2] = -19;
        }
    }
}
