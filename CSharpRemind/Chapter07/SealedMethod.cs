using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    internal class SealedMethod
    {
        class Base3
        {
            public virtual void SealMe()
            {

            }
        }

        class Derived3 : Base3
        {
            public sealed override void SealMe()
            {
                
            }
        }

        class WantToOverride : Derived3
        {
            //public override void SealMe()
            //{ }
        }
    }
}
