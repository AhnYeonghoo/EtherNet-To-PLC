using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    class Cat2
    {
        public Cat2()
        {
            Name = "";
            Color = "";
        }

        public Cat2(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat2()
        {
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    internal class Constructor
    {
        static void MainConstructor()
        {
            Cat2 kitty = new Cat2("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat2 nero = new Cat2("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
