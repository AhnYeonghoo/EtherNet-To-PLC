using System;
using System.Linq;

namespace Method
{
    abstract class Motorcycle
    {
        public void StartEngine() { }
        public void AddGas(int gallons) { }
        public virtual int Drive(int miles, int speed) { return 1; }
        public virtual int Drive(TimeSpan time, int speed) { return 0; }
        public abstract double GetTopSpeed();

    }

    class TestMotorcycle : Motorcycle
    {
        public override int Drive(int miles, int speed)
        {
            return (int)Math.Round(((double)miles) / speed, 0);
        }

        public override double GetTopSpeed()
        {
            return 108.4;
        }
    }

    public class Person
    {
        public String FirstName;

        public override bool Equals(object obj)
        {
            var p2 = obj as Person;
            if (p2 == null) return false;
            else return FirstName.Equals(p2.FirstName);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode();
        }
    }


    public class SquareExample
    {
        public static void Main()
        {
            int num = 4;
            int productA = Square(num);
            int productB = Square(12);
            int productC = Square(productA * 3);

            TestMotorcycle moto = new TestMotorcycle();

            moto.StartEngine();
            moto.AddGas(15);
            moto.Drive(5, 20);
            double speed = moto.GetTopSpeed();
            Console.WriteLine("My Top speed {0}", speed);

            var traveTime = moto.Drive(speed: 60, miles: 170);
            Console.WriteLine("Travel time: approx. {0} hours", traveTime);

            Console.WriteLine("------Person------");
            var p1 = new Person();
            p1.FirstName = "John";
            var p2 = new Person();
            p2.FirstName = "John";
            Console.WriteLine("p1 == p2 {0}", p1.Equals(p2));

            Console.WriteLine("ByValuePass");
            Console.WriteLine();

            int value = 20;
            Console.WriteLine("In Main, value = {0}", value);
            ModifyValue(value);
            Console.WriteLine("Back in Main, Value = {0}", value);

            Console.WriteLine("ByRefTypePass");
            Console.WriteLine();

            var rt = new SampleRefType();
            rt.value = 44;
            ModifyObject(rt);
            Console.WriteLine(rt.value);

            int value2 = 20;
            Console.WriteLine("In Main, value ={0}", value2);
            ModifyValue(ref value2);
            Console.WriteLine($"Back in Main, value ={value2}");

            Console.WriteLine("Ref Swap Example... ---- ");
            int i = 2, j = 3;
            Console.WriteLine($"i = {i}, j = {j}");
            Swap(ref i, ref j);
            Console.WriteLine($"i = {i}, j = {j}");

            Console.WriteLine("----- Params Example -----");
            Console.WriteLine();

            string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
            Console.WriteLine($"Vowels from array : {fromArray}");

            string fromMultipleArguments = GetVowels("apple", "banana", "Pear");
            Console.WriteLine($"Vowels from multiple arguments: {fromMultipleArguments}");

            string fromNull = GetVowels(null);
            Console.WriteLine($"Vowels from Null: {fromNull}");

            string fromNoValue = GetVowels();
            Console.WriteLine($"Vowels from to value:  {fromNoValue}");

            Console.WriteLine("Optional Example... ");
            Console.WriteLine();
            var opt = new Options();
            opt.ExampleMethod(10);
            opt.ExampleMethod(10, 2);
            opt.ExampleMethod(10, description: "Addition with zero: ");


        }

        public class Options
        {
            public void ExampleMethod(int required, int optionalInt = default,
                string? description = default)
            {
                var msg = $"{description ?? "N/A"}: {required} + {optionalInt} = {required + optionalInt}";
                Console.WriteLine(msg);
            }
        }

        static string GetVowels(params string[] input)
        {
            if (input == null || input.Length == 0)
            {
                return string.Empty;
            }
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(
                input.SelectMany(
                    word => word.Where(letter =>
                    vowels.Contains(char.ToUpper(letter)))));
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public class SampleRefType
        {
            public int value;
        }

        static void ModifyValue(ref int i)
        {
            i = 30;
            Console.WriteLine("In ModifyValue, Parameter value = {0}", i);
        }

        static void ModifyObject(SampleRefType obj)
        {
            obj.value = 33;

        }
        static void ModifyValue(int i)
        {
            i = 30;
            Console.WriteLine("In ModifyValue, parameter value = {0}", i);
            return;
        }

        static int Square(int i)
        {
            int input = i;
            return input * input;
        }
    }
}