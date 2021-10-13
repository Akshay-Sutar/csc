using System;

namespace AsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // as operator type casts the variable to the target
            // on failure, null is returned
            String character = "Bond";
            Object o = character;

            String person = character as String;
            Console.WriteLine($"The name's {person}");
        }
    }
}
