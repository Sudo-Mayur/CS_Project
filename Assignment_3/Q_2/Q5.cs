using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //Can we type cast the derived class instance using the base class?
    public class Q5
    {
        public void Methode1(int a, int b)
        {
            Console.WriteLine(a + b);

        }

    }
    public class Name1 : Q5
    {
        public void Methode2(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);

        }
    }
}

