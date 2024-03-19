using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter15
{
    internal class GroupBy
    {
        static void MainGroupBy()
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");
                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine($" {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}
