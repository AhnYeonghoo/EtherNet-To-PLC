using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter09
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }

    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }


        internal class PropertiesInInterface
        {
            static void MainPropertiesInInterface()
            {
                NamedValue name = new NamedValue()
                { Name = "미흥", Value = "박상현" };
                NamedValue height = new NamedValue()
                { Name = "키", Value = "177cm" };
                NamedValue weight = new NamedValue()
                { Name = "몸무게", Value = "90kg" };
                Console.WriteLine($"{name.Name} : {name.Value}");
                Console.WriteLine($"{height.Name} : {height.Value}");
                Console.WriteLine($"{weight.Name} : {weight.Value}");
            }
        }
    }
}
