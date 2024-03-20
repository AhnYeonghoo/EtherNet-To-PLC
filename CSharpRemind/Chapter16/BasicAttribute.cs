using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter16
{
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I`m old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I`m new");
        }
    }
    internal class BasicAttribute
    {
        static void MainBasicAtrribute()
        {
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();
        }
    }
}
