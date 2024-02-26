using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    internal class This
    {
        class Employee
        {
            private string Name;
            private string Position;

            public void SetName(string Name)
            {
                this.Name = Name;
            }

            public string GetName()
            {
                return this.Name;
            }

            public string GetPosition()
            {
                return this.Position;
            }

            public void SetPosition(string Position)
            {
                this.Position = Position;
            }
        }

        static void MainThis()
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {pooh.GetPosition()}");
        }
    }
}
