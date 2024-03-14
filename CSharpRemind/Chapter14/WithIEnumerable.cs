using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter14
{
    class NameCard
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
    internal class WithIEnumerable
    {
        static void MainWithIEnumerable()
        {
            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard() { Name = "박상현", Phone = "010-5162-1234" });
            list.Add(new NameCard() { Name = "이지은", Phone = "010-9712-3361" });
            list.Add(new NameCard() { Name = "정가은", Phone = "010-9712-3361" });
            list.Add(new NameCard() { Name = "김승수", Phone = "010-9712-3361" });
            IEnumerable<NameCard> result = list.Where<NameCard>(namecard => namecard.Name.EndsWith("은"));

            foreach (NameCard namecard in result)
            {
                Console.WriteLine($"{0} : {1}", namecard.Name, namecard.Phone);
            }
        }
    }
}
