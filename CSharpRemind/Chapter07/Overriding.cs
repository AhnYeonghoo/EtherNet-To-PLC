using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter07
{
    internal class Overriding
    {

        class ArmorSuite
        {
            public virtual void Initialize()
            {
                Console.WriteLine("Armored");
            }
        }

        class IronMan : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Repulsor Rays Armed");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Double-Barrel Cannons Armed");
                Console.WriteLine("Micro-Rocket Launcher Armed");
               
            }
        }

        static void MainOverriding()
        {
            Console.WriteLine("Creating ArmorSuite");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}
