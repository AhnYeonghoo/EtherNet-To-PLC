using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter09
{
    class BirthdayInfo3
    {
        public string Name
        {
            get;
            set;

        }

        public DateTime Birthday
        {
            get;
            set;

        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class ConstructorWithProperty
    {

        static void MainConstructorWithProperty()
        {
            BirthdayInfo3 birth = new BirthdayInfo3()
            {
                Name = "서련",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday}");
            Console.WriteLine($"Age: {birth.Age}");

        }
    }
}
