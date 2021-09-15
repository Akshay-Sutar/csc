using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Shape();
            Shape cuboid = new Shape();

            Console.WriteLine($"Area is "+rectangle.getDimension(5,10));
            Console.WriteLine($"Volume is " + cuboid.getDimension(5, 10, 15));
        }
    }
}
