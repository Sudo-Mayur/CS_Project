using System;

namespace Math_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The max number is :" + Math.Max(a, b));
            Console.WriteLine("The min number is :" + Math.Min(a, b));
            Console.WriteLine();

            Console.WriteLine("Enter non-Absolute or negative value number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Absolute value  is :" + Math.Abs(c));
            Console.WriteLine();

            Console.WriteLine("Enter value in floating point number");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The round-up value  is :" + Math.Round(d));
            Console.WriteLine();

            Console.WriteLine("Enter number");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square root  is :" + Math.Sqrt(d));

            Console.WriteLine("Enter value in floating point number");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The round-up value is :" + Math.Floor(f));
            Console.WriteLine();

            Console.WriteLine("Enter value in floating point number");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The round-up value is :" + Math.Ceiling(g));
            Console.WriteLine();

            Console.WriteLine("Enter the value");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sin(h * (Math.PI / 180)));
            Console.WriteLine();

            Console.WriteLine("Enter the value");
            double i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Asin(i) * (180 / Math.PI));
            Console.WriteLine();














        }
    }
}
