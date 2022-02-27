using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //Can we derive a public class from internal class?
    internal class Q8
    {
        string name = "Mayur";
    } 
    public class ClassQ8 : Q8
    {
        int age = 21;
    }
}
