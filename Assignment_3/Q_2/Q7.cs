using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //Can we have same property in base and derived class?
    public class Q7
    {
        public int MyProperty { get; set; }
    }
    public class MyClass1: Q7
    {
        public int MyProperty { get; set; }

    }
}
