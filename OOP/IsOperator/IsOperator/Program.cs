using System;

namespace IsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int? y = null;

            if (x is int)
            {
                Console.WriteLine("x is an integer");
            }

            if (y is null)
            {
                Console.WriteLine("y is null");
            }
        }
    }
}
