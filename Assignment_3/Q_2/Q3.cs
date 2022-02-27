using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    public abstract class Q3
    {
        //Can we have private and protected abstract and virtual methods in abstract base class?
        private void Methode1()
        {
            Console.WriteLine("Name");
        }
        protected abstract void Methode2();
        public void Methode3()
        {
            Console.WriteLine("Sirname");
        }
        

    }
    public class MyClass: Q3
    {

    }
}
