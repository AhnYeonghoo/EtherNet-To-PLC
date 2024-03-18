﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    internal class SimpleLinq
    {
        static void MainSimpleLinq()
        {
            Profile[] arrProfile =
            {
                new Profile() {Name="정우성", Height=186},
                new Profile() {Name="김태희", Height=158},
                new Profile() {Name="고현정", Height=172},
                new Profile() {Name="이문세", Height=178},
                new Profile() {Name="하하", Height=171},
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               IncHEight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
            {
                Console.WriteLine($"{profile.Name}, {profile.IncHEight}");
            }

        }
    }
}
