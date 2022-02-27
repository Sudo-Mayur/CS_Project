using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //What will happen if the derive class does not override all abstract methods of the abstract class?
    public abstract class Q14
    {
       public abstract void Main3();
       public abstract void Main4();

    }
    public class ClassQ14 : Q14
    {
        public override void Main3()
        {

        }     

    }
}
