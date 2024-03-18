using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter15
{
    
    internal class SimpleLinq2
    {
        static void MainSimpleLinq2()
        {
            Profile[] arrProfile =
                {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하하", Height = 171 }
            };

            var profiles = arrProfile.
                            Where(profile => profile.Height < 175).
                            OrderBy(profile => profile.Height).
                            Select(profile =>
                            new
                            {
                                Name = profile.Name,
                                IncHeight = profile.Height,
                            });
            foreach (var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.IncHeight}");
            }
                    
        }
    }
}
