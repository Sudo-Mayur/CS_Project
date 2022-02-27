using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //Can we have internal virtual or abstract methods in abstract class?
    public abstract class Q9
    {
       public  abstract void Main1();
        internal virtual void Main2()
        {
            Console.WriteLine("Name");
        }
      
        
    }
    public class ClassQ9 : Q9
    {
        public override void Main1()
        {
            Console.WriteLine("Main");
        }
        internal override void Main2()  //Acsess specifire should be same
        {
            Console.WriteLine("Mayur");
        }
    }
}
