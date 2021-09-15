using System;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1,2);
            Point b = new Point(3, 4);
            Point c = a + b;
            Console.WriteLine($" sum of 2 points is "+ c.ToString());
        }
    }
}