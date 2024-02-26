using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{

    class Cat
    {
        public string Name;
        public string Color;
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    internal class BasicClass
    {
        static void MainBasicClass()
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
            
        }
    }
}
