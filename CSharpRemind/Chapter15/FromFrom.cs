using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter15
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    internal class FromFrom
    {
        static void MainFromFrom()
        {
            Class[] arrClass =
            {
                new Class(){Name="연두반", Score=new int[]{99, 80, 70, 24}},
                new Class(){Name="분홍반", Score=new int[]{60, 45, 87, 72}},
                new Class(){Name="파랑반", Score=new int[]{92, 30, 85, 94}},
                new Class(){Name="노랑반", Score=new int[]{90, 88, 0, 17}}
            };

            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };
            foreach (var c in classes)
                Console.WriteLine($"낙제 : {c.Name}, ({c.Lowest})");
        }
    }
}
