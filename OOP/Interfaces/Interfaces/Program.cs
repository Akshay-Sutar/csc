using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamborghini Huracan = new Lamborghini();
            Audi R8 = new Audi();

            R8.accelerate();
            Huracan.accelerate();

            Console.WriteLine($"Audi current speed is {R8.CurrentSpeed}");
            Console.WriteLine($"Huracan current speed is {Huracan.CurrentSpeed}");
        }
    }
}
