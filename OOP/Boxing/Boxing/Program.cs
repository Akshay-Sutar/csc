using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            // CLR is boxing the int i to Object o
            Object o = i;

            Console.WriteLine($" i value is {i}");
            Console.WriteLine($" o value is {o}");
               
            // after changing o value, i is not affected
            o = 20;
            Console.WriteLine($" i value is {i}");
            Console.WriteLine($" o value is {o}");

            // o is unboxed
            int j = (int)o;
            Console.WriteLine($" i value is {i}");
            Console.WriteLine($" i value is {i}");
            Console.WriteLine($" j value is {j}");
        }
    }
}
