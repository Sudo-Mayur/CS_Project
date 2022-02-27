using System;

namespace ConsoleApp3
{
    internal class Program
    {
        public int sampleMethode(int var)
        {
            var += 4;
            return var;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int var = 6;
            Console.WriteLine(obj.sampleMethode(var));
        }
    }
}
