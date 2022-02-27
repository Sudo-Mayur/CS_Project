using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //Can we override the private virtual method of abstract class using public method from the deriuved class?
    public abstract class Name
    {
         private virtual void Methode()
        {
            Console.WriteLine("Mayur");
        }
    }
    public class Mayur : Name
    {
        public override void Methode()
        {
            Console.WriteLine("I am 21 Years Old");
        }
    }
      

}
