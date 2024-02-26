using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    internal class Inheritance
    {
        class Base
        {
            protected string Name;
            
            public Base(string Name)
            {
                this.Name = Name;
                Console.WriteLine($"{this.Name}.Base()");
            }

            ~Base()
            {
                Console.WriteLine($"{this.Name}.~Base()");
            }

            public void BaseMethod()
            {
                Console.WriteLine($"{this.Name}.BaseMethod()");
            }
        }

        class Derived : Base
        {
            public Derived(string Name) : base(Name)
            {
                Console.WriteLine($"{this.Name}.Derived()");
            }

            ~Derived()
            {
                Console.WriteLine($"{this.Name}.Derived()");
            }

            public void DerivedMethod()
            {
                Console.WriteLine($"{Name}.DerivedMethod()");
            }
        }

        static void MainInheritance()
        {
            Base a = new Base("A");
            a.BaseMethod();

            Derived b = new Derived("B");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
