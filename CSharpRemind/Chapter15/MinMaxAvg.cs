using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter15
{
    internal class MinMaxAvg
    {
        static void MainMinMaxAvg()
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                 Group = g.Key == true ? "175미만" : "175이상",
                                 Count = g.Count(),
                                 Max = g.Max(profile => profile.Height),
                                 Min = g.Min(profile => profile.Height),
                                 Average = g.Average(profile => profile.Height),
                             };

            foreach (var stat in heightStat)
            {
                Console.WriteLine("{0} - Count:{1}, Max:{2}", stat.Group, stat.Count, stat.Max);
                Console.WriteLine("Min:{0}, Average:{1}", stat.Min, stat.Average);
            }

                 
        }
    }
}
