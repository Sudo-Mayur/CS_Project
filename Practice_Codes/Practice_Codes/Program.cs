using System;

namespace Practice_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}",dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:f}", dt);
            Console.WriteLine("{0:F}", dt);
            Console.WriteLine("{0:g}", dt);
            Console.WriteLine("{0:G}", dt);
            Console.WriteLine("{0:y}", dt);

        }
    }
}
