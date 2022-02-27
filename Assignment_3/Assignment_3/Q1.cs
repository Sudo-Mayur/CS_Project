using System;

namespace Assignment_3
{
    internal class Program
    {
        //Q1 Can overloading is possible by having same method name with same number and order of parameters but different in return type?
        public void Methode1(int a,int b)
        {
            Console.WriteLine(a+b);

        }
        public int Methode1(int a, int b)
        {
            return a + b;

        }

    }
}
