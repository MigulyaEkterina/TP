using System;

namespace l1
{
    class Points
    {
        public char a = 'c';
        public const uint b = 9;
        public short[] c = new short[5] {1,2,2,2,2 };
        public enum Integers
        {
            one,
            two,
            three
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Points p = new Points();
            
            Console.WriteLine(p.c[1]);
            Console.WriteLine(Points.b);
            Console.WriteLine(Points.Integers.one);
            Console.WriteLine(Char.IsLower(p.a));

        }
    }
}
