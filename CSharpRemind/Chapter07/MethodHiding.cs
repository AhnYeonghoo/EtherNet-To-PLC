using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    internal class MethodHiding
    {
        class Base2
        {
            public void MyMethod()
            {
                Console.WriteLine("Base2.MyMethod()");
            }
        }

        class  Derived2 : Base2
        {
            public new void MyMethod()
            {
                Console.WriteLine("Derived.MyMethod()");
            }
        }
        static void MainMethodHiding()
        {
            Base2 baseobj = new Base2();
            baseobj.MyMethod();

            Derived2 d = new Derived2();
            d.MyMethod();

            Base2 baseOrDerived = new Derived2();
            baseOrDerived.MyMethod();
        }
    }
}
