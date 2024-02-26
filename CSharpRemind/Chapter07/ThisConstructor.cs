using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    internal class ThisConstructor
    {
        class MyClass2
        {
            int a, b, c;

            public MyClass2()
            {
                this.a = 5424;
                Console.WriteLine("MyClass()");
            }

            public MyClass2(int b) : this()
            {
                this.b = b;
                Console.WriteLine($"MyClass2({b})");
            }

            public MyClass2(int b, int c) : this(b)
            {
                this.c = c;
                Console.WriteLine($"MyClass2({b}, {c})");
            }

            public void PrintFields()
            {
                Console.WriteLine($"a: {a}, b: {b}, c: {c}");
            }
        }

        static void MainThisConstructor()
        {
            MyClass2 a = new MyClass2();
            a.PrintFields();
            Console.WriteLine();

            MyClass2 b = new MyClass2(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass2 c = new MyClass2(10, 20);
            c.PrintFields();
        }
    }
}
