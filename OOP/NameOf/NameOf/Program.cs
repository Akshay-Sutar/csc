using System;

namespace NameOf
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi_value = 3.14f;
            Console.WriteLine($"name of variable holding pi value is {nameof(pi_value)}");
        }
    }
}
