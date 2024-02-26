﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter09
{
    record RTransaction2
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }

    }
    internal class WithExp
    {
        static void MainWithExp()
        {
            RTransaction2 tr1 = new RTransaction2 { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction2 tr2 = tr1 with { To = "Charlie" };
            RTransaction2 tr3 = tr2 with { From = "Dave", Amount = 30 };
            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }
}
