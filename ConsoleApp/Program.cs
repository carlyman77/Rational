using System;

using Numerics;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] arguments)
        {
            Rational<decimal> a = new Rational<decimal>(1, 4);
            Rational<decimal> b = new Rational<decimal>(1, 2);

            Console.WriteLine(a * b);
            Console.WriteLine(a + b);
        }
    }
}
