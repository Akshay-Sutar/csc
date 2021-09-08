using System;
using Constructors2;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo p1 = new(10);
            Demo p2 = new Demo(p1);
            p2.Value = 20;

            Console.WriteLine($"static value is {Demo.Range}");
            Console.WriteLine($"p1 value = {p1.Value}");
            Console.WriteLine($"p2 value = {p2.Value}");
        }
    }
}
