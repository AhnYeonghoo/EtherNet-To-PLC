using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter09
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    record RTransaction3
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }
        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    internal class RecordComp
    {
        static void MainRecordComp()
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine(trA.Equals(trB));

            RTransaction3 tr1 = new RTransaction3 { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction3 tr2 = new RTransaction3 { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(tr1.Equals(tr2));

        }

    }
}
