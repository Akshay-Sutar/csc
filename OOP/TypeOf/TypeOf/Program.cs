using System;

namespace TypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            // typeof returns the type at the compile time
            Console.WriteLine($"type of x is {typeof(int)}");

            // GetType() can be used on the variable
            Console.WriteLine($"type of x is {x.GetType()}");
        }
    }
}
