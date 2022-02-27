using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //Can we have method overloading across base and deried classe?
    public class A
    {
        private void Methode1(int a, int b)
        {
            Console.WriteLine(a + b);

        }
       
    }
    public class B : A
    {
        public int Methode1(int a, int b, int c)
        {
            return a + b+ c;

        }
    }


}
