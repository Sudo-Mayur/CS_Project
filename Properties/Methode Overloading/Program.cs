using System;

namespace Methode_Overloading
{
    internal class Program
    {
       static void Sum(int x,int y)     // In methode overloading there are more than one methode in class having same 
                                        // name but methods parameters are differents.
        {
            int z = x + y;
            Console.WriteLine(z);
        }
         static void Sum(int x, int y, int z)
        {
            int m = x + y + z;
            Console.WriteLine(m);
        }
        static void Sum(int x, int y, int z,int p)
        {
            int n = x + y + z + p;
            Console.WriteLine(n);
        }

        class calculation
        {
            public static void Main(string []args)
            {
                Sum(2, 3);
                Sum(6,4,7);
                Sum(9,3,2);
            }
        }

    }
}
