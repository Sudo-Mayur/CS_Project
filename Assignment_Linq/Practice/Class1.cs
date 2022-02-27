using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var EmpQuery1 =
           from emp in Employee
           orderby emp.EmpName ascending
           select emp;
            Console.WriteLine("Name of Employees in ascending order:");
            foreach (var item in EmpQuery1)
            {
                Console.WriteLine(item.EmpName);
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
