using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2
{
    //can we have public property in abstract base class?
    public abstract class CQ6
    {
        public int MyProperty { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
