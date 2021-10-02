using System;

namespace ConstantKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstantKeyword shape = new ConstantKeyword();
            float radius = 10f;
            float height = 12f;

            Console.WriteLine("Area is : " + shape.getArea(radius));
            Console.WriteLine("Volume is : " + shape.getVolume(radius, height));
        }
    }
}
