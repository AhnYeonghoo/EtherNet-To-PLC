using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsumerVehicleRegistration
{
    public class Car
    {
        public int Passengers { get; set; }
    }
}

namespace CommercialRegistration
{
    public class DeliveryTruck
    {
        public int GrossWeightClass { get; set; }
    }
}

namespace LiveryRegistration
{
    public class Taxi
    {
        public int Fares { get; set; }
    }

    public class Bus
    {
        public int Capacity { get; set; }
        public int Riders { get; set; }
    }
}


namespace ExampleCSharp
{
    public class SafetyCating
    {
        int? j = null;
        public  void MainSafetyCasting()
        {
            var g = new Giraffe();
            var a = new Animal();

            FeedMammals(g);
            FeedMammals(a);

            SuperNova sn = new SuperNova();
            TestForMammals(g);
            TestForMammals(sn);

            Console.WriteLine("\n\n");

            int i = 5;
            PatternMatchingNullable(i);

           
            PatternMatchingNullable(j);

            double d = 9.78654;
            PatternMatchingNullable(d);

            PatternMatchingSwitch(i);
            PatternMatchingSwitch(j);
            PatternMatchingSwitch(d);

            Giraffe g2 = new();
            UseIsOperator(g);

            UseAsOperator(g);

            UsePatternMatchingIs(g);
            SuperNova sn2= new();
            UseAsOperator(sn2);

            UseAsWithNullable(i);
            UseAsWithNullable(d);
        }

        static void UseIsOperator(Animal a)
        {
            if (a is Mammal)
            {
                Mammal m = (Mammal)a;
                m.Eat();
            }
        }

        static void UsePatternMatchingIs(Animal a)
        {
            if (a is Mammal m)
            {
                m.Eat();
            }
        }

        static void UseAsOperator(object o)
        {
            Mammal? m = o as Mammal;
            if (m is not null)
            {
                Console.WriteLine(m.ToString());
            }
            else
            {
                Console.WriteLine($"{o.GetType().Name} is not a Mammal");
            }
        }

        static void UseAsWithNullable(System.ValueType val)
        {
            int? j = val as int?;
            if (j is not null)
            {
                Console.WriteLine(j);
            }
            else
            {
                Console.WriteLine("could not convert " + val.ToString());
            }
        }
        static void PatternMatchingNullable(ValueType? val)
        {
            if (val is int j)
            {
                Console.WriteLine(j);
            }
            else if (val is null)
            {
                Console.WriteLine("val is a nullable type with the null value");
            }
            else
            {
                Console.WriteLine("Could not convert " + val.ToString());
            }
        }

        static void PatternMatchingSwitch(ValueType? val)
        {
            switch (val)
            {
                case int number:
                    Console.WriteLine(number);
                    break;
                case long number:
                    Console.WriteLine(number);
                    break;
                case decimal number:
                    Console.WriteLine(number);
                    break;
                case float number:
                    Console.WriteLine(number);
                    break;
                case double number:
                    Console.WriteLine(number);
                    break;
                case null:
                    Console.WriteLine("Val is a nullable type with the null value");
                    break;
                default:
                    Console.WriteLine("Could not convert " + val.ToString());
                    break;
            }
        }
        static void FeedMammals(Animal a)
        {
            if (a is Mammal m)
            {
                m.Eat();
            }
            else
            {
                Console.WriteLine($"{a.GetType().Name} is not a Mammals");
            }
        }

        static void TestForMammals(object o)
        {
            var m = o as Mammal;
            if (m != null)
            {
                Console.WriteLine(m.ToString());
            }
            else
            {
                Console.WriteLine($"{o.GetType().Name} is not a Mammals");
            }
        }
    }

    class Animal
    {
        public void Eat() { Console.WriteLine("Eating"); }
        public override string ToString()
        {
            return "I am an Animal";
        }
    }
    class Mammal : Animal { }
    class Giraffe : Mammal { }
    class SuperNova { }
}
