using System;

namespace Enum
{
    public enum SomeRootVegetable
    {
        HorseRadish,
        Radish,
        Turnip
    }


    [Flags]
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }

    public class Enum
    {
        public static void MainEnum()
        {
            var turnip = SomeRootVegetable.Turnip;
            var spring = Seasons.Spring;
            var startingOnEquipnox = Seasons.Spring | Seasons.Autumn;
            var theYear = Seasons.All;

            Console.WriteLine(turnip);
            Console.WriteLine(spring);
            Console.WriteLine(startingOnEquipnox);
            Console.WriteLine(theYear);

            int? optionalInt = default;
            optionalInt = 5;
            string? optionalText = default;
            optionalText = "Hello World";

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}");
            Console.WriteLine(optionalInt);
            Console.WriteLine(optionalText);
        }

    }
}