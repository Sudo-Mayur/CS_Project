using System;

namespace Assignment3_CS
{
    internal abstract class Program
    {
        //Can we have public property in abstract base class?
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set;}

        public class MyClass : Program
        {

        }







        //static void Sum(int x, int y)     // In methode overloading there are more than one methode in class having same 
        //                                  // name but methods parameters are differents.
        //{
        //    int z = x + y;
        //    Console.WriteLine(z);
        //}
        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //static double Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //class calculation
        //{
        //    public static void Main(string[] args)
        //    {
        //        Sum(2, 3);

        //    }
        //}
    }
}
