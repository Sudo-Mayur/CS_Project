using System;

namespace Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int obj = Add(a, b);
            Console.WriteLine("The addition of numbers is :" + obj);
            int obj1 = Sub(a, b);
            Console.WriteLine("The addition of numbers is :" + obj1);
            int obj2 = Mul(a, b);
            Console.WriteLine("The addition of numbers is :" + obj2);
            int obj3 = Div(a, b);
            Console.WriteLine("The addition of numbers is :" + obj3);
            int obj4 = Square(a);
            Console.WriteLine("The addition of numbers is :" + obj4);

            Console.WriteLine();

            Console.WriteLine("Addition :");
            Console.WriteLine("Enter first number");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secod number");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Add(a, b);
            Console.WriteLine("The addition of numbers is :" + result);

            Console.WriteLine();

            Console.WriteLine("Substraction :");
            Console.WriteLine("Enter first number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secod number");
            int d = Convert.ToInt32(Console.ReadLine());
            int result1 = Sub(c, d);
            Console.WriteLine("The substraction of numbers is :" + result1);

            Console.WriteLine();

            Console.WriteLine("Multiplication :");
            Console.WriteLine("Enter first number");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secod number");
            int f = Convert.ToInt32(Console.ReadLine());
            int result2 = Mul(e, f);
            Console.WriteLine("The substraction of numbers is :" + result2);

            Console.WriteLine();

            Console.WriteLine("Division :");
            Console.WriteLine("Enter first number");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secod number");
            int h = Convert.ToInt32(Console.ReadLine());
            int result3 = Div(g, h);
            Console.WriteLine("The division of numbers is :" + result3);

            Console.WriteLine();

            Console.WriteLine("Square :");
            Console.WriteLine("Enter number");
            int i = Convert.ToInt32(Console.ReadLine());
            int result4 = Square(i);
            Console.WriteLine("The square of numbers is :" + result4);


            static int Add(int x, int y)
            {
                int z = 0;
                z = x + y;
                return z;
            }
            static int Sub(int x, int y)
            {
                int z = 0;
                z = x - y;
                return z;
            }
            static int Mul(int x, int y)
            {
                int z = 0;
                z = x * y;
                return z;
            }
            static int Div(int x, int y)
            {
                int z = 0;
                z = x / y;
                return z;

            }
            static int Square(int x)
            {
                int z = 0;
                z = x * x;
                return z;

            }
        }

    }
}
