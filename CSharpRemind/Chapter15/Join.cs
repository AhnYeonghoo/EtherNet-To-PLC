using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter15
{
    class Profile2
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product2
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    internal class Join
    {
       static void Main()
        {
            Profile2[] arrPRofile =
            {
                new Profile2(){Name="정우성", Height=186},
                new Profile2(){Name="김태희", Height=158},
                new Profile2(){Name="고현정", Height=172},
                new Profile2(){Name="이문세", Height=178},
                new Profile2(){Name="하하", Height=171}
            };

            Product2[] arrProduct =
            {
                new Product2(){Title="비트",        Star="정우성"},
                new Product2(){Title="CF 다수",     Star="김태희"},
                new Product2(){Title="아이리스",    Star="김태희"},
                new Product2(){Title="모래시계",    Star="고현정"},
                new Product2(){Title="Solo 예찬",   Star="이문세"}
            };

            var listProfile =
                from profile in arrPRofile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height,
                };

            Console.WriteLine("--- 내부 조인 결과 ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine($"이름: {profile.Name}, 작품: {profile.Work}, 키: {profile.Height}");
            }


            listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps
                from product in ps.DefaultIfEmpty(new Product2() { Title = "그런거 없음" })
                select new
                {
                    Name = profile.Name,
                    Work = profile.Title,
                    Height = profile.Height,
                };

            Console.WriteLine();
            Console.WriteLine("--- 외부 조인 결과 ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름; {0}, 작품: {1}, 키: {2}cm",
                    profile.Name, profile.Work, profile.Height);
            }
        }
    }
}
