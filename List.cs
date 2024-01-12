using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace List
{
    public class ListPrac
    {

        private void WorkWithStrings()
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            Console.WriteLine($"My Name is {names[0]}");
            Console.WriteLine($"I`ve added {names[2]} and {names[3]} to the list");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
        }

        private string[] names = { "spencer", "Saliy", "Doug" };

        public ListPrac(string[] names)
        {
            this.names = names;
        }

        public string GetName(int ID)
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }

        public void DataType()
        {
            ListPrac work = new ListPrac();
            // work.WorkWithStrings();

            var fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            // Declaration only
            float temperature;
            string name;

            char firsthLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            var query = from item in source
                        where item <= limit
                        select item;
            foreach (var d in query)
            {
                Console.WriteLine(d);
            }


            byte b = byte.MaxValue;
            Console.WriteLine(b);

            byte num = 0xA;
            Console.WriteLine((byte)num);
        }

        public static T[] SubArray<T>(this T[] data, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
            => self.Select((item, index) => (item, index));



        public struct Coords
        {
            public int x, y;
            public Coords(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }

        public enum FileMode
        {
            CreateNew = 1,
            Create = 2,
            Open = 3,
            OpenOrCreate = 4,
            Truncate = 5,
            Append = 6,
        }

        public class Container
        {
            private int _capacity;
            public Container(int capacity) => _capacity = capacity;
        }

        //public class Person
        //{
        //    public string FirstName;
        //    public string LastName;
        //    public string[] PhoneNumbers { get; set; }
        //}

        //public class Person
        //{
        //    public required string LastName { get; set; }

        //}

        private class ExampleClass { }

        private void MainTestMethod()
        {
            string s = "The answer is " + 5.ToString();
            Console.WriteLine(s);

            Type type = 12345.GetType();
            Console.WriteLine(type);

            List<string> stringList = new List<string>();
            stringList.Add("String example");

            Console.WriteLine("-----");
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);

            GenericList<string> list2 = new GenericList<string>();
            list2.Add("");


            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            NodeTest.GenericList<int> list = new NodeTest.GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                list.AddHead(x);
            }

            foreach (int i in list)
            {
                System.Console.WriteLine(i + " ");
            }
            System.Console.WriteLine("\nDone");

        }

        public static void MainList()
        {
            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v.Amount + v.Message);

            Person.Person person1 = new Person.Person("Leopold", 6);
            Console.WriteLine($"person1 Name: {person1.Name}, Age = {person1.Age}");

            Person.Person person2 = person1;

            person2.Name = "Molly";
            person2.Age = 16;
            Console.WriteLine($"person1 Name: {person1.Name}, Age = {person1.Age}");
            Console.WriteLine($"person2 Name: {person2.Name}, Age = {person2.Age}");






        }

        // Declare the generic class.
        public class GenericList<T>
        {
            public void Add(T input) { }
        }
        
        public class Car : IEquatable<Car>
        {
            public string? Make { get; set; }
            public string? Model { get; set; }
            public string? Year { get; set; }

            public bool Equals(Car? car)
            {
                return (this.Make, this.Model, this.Year) ==
                    (car?.Make, car?.Model, car?.Year);
            }
        }
    }
}

namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

namespace NodeTest
{
    public class GenericList<T>
    {
        private class Node
        {
            private Node? next;
            public Node? Next { get { return next; } set { next = value; } }

            private T data;
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
            public Node(T t)
            {
                next = null;
                data = t;
            }


        }
        private Node? head;
        public GenericList()
        {
            head = null;
        }

        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node? current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");
        }
    }
}