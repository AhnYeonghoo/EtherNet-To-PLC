using System;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public DateTime Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }

    
    }

    class BirthdayInfoAuto
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }

    class ConstuctorProperty
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

    

  
    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "SeoHyeon";
            birth.Birthday = new DateTime(1991, 6, 28);
            Console.WriteLine($"Name: {birth.Name}");
            Console.WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age: {birth.Age}");

            ConstuctorProperty birth2 = new ConstuctorProperty()
            {
                Name = "SeoHyeon",
                Birthday = new DateTime(1991, 6, 28),
            };

            Console.WriteLine("d");

            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");
            var b = new { Subject = "Math", Scores = new int[] { 90, 80, 70, 60 } };
            foreach (var score in b.Scores)
            {
                Console.WriteLine($"{score}");
            }
            
        }
    }
}