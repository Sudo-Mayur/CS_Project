using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Assignment_7
{
    internal class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { FileName="Program", FilePath= @"C:\Users\Coditas\Desktop\C# All Code.zip\C# All Code\2 If else statement" });
        }
    }
}
