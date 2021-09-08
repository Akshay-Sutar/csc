using System;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new(3, 4);
            Console.WriteLine(c.ToString());
        }
    }
}
