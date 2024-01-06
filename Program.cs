using System;

namespace CSharp
{

    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

   
    public class Point
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y) => (X, Y) = (x, y); 

    }

    public class Point3D : Point
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

    }

    
    public class Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public Pair(TFirst first, TSecond second) => (First, Second) = (first, second);
    }
    public class Program
    {
        public static void MainProgram(string[] args)
        {
            var p1 = new Point(0, 0);
            var p2 = new Point(10, 20);
            var pair = new Pair<int, string>(1, "two");
            int i = pair.First;
            string s = pair.Second;
            int p3 = p1.X;
            int p4 = p2.Y;
            Console.WriteLine(i);
            Console.WriteLine(s);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
        }
    }

    
}
