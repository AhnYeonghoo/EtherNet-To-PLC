using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Global
{
    public static int Count = 0;
}

class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}

class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}
namespace CSharpRemind.Chapter07
{
    
    internal class StaticField
    {
        static void MainStaticField()
        {
            Console.WriteLine($"Global.Count: {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();
            Console.WriteLine($"Global.Count: {Global.Count}");


        }
    }
}
