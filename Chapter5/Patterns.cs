using System;

namespace Chapter5
{
    class Patterns
    {
        class Preschooler { }
        class Underage { }
        class Adult { }
        class Senior { }

        static int CalculateFee(object visitor)
        {
            return visitor switch
            {
                Underage => 100,
                Adult => 500,
                Senior => 200,
                _ => throw new ArgumentException($"Prohibited age {visitor.GetType()}, {nameof(visitor)}"),

            };
        }

        class Car
        {
            public string Model { get; set; }
            public DateTime ProducedAt { get; set; }
        }

        static string GetNickName(Car car)
        {
            var GenerateMessage = (Car car, string nickname) =>
            $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";
        }

        static void Main()
        {
            // Declaration Pattern
            object foo = 23;
            if (foo is int bar)
                Console.WriteLine(bar);

            // Type Pattern
            if (foo is int)
                Console.WriteLine(foo);

            Console.WriteLine($"Fee for a Senior : {CalculateFee(new Senior())}");
            Console.WriteLine($"Fee for a adult: {CalculateFee(new Senior())}");
            Console.WriteLine($"Fee for a underage: {CalculateFee(new Underage())}");
            Console.WriteLine($"Fee for a preschooler: {CalculateFee(new Preschooler())}");

            // Constant Pattern
            var GetCountryCode = (string nation) => nation switch
            {
                "KR" => 82,
                "US" => 1,
                "UK" => 44,
                _ => throw new ArgumentException("Not supported Code"),
            };

            Console.WriteLine(GetCountryCode("KR"));
            Console.WriteLine(GetCountryCode("US"));
            Console.WriteLine(GetCountryCode("UK"));

            // Property Pattern

        }

    }
}
