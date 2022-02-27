using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    public class Q12
    {
        //Can we have virtual method in not-abstract class?
        public virtual void Methode3()
        {

        }
    }
    public class classQ12 : Q12
    {
        public override void Methode3()
        {

        }
    }
}
