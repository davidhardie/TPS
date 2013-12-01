using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int MyProperty { get; set; }
        public bool MyProperty2 { get; set; } // to make a change

        public Class1()
        {
            MyProperty = 1;
            MyProperty2 = true;
        }
    }
}
