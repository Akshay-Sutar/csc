using System;

namespace Destructor
{

    class First
    {
        public First()
        {
            Console.WriteLine("First constructor");
        }
        ~First()
        {
            Console.WriteLine("First destructor");
        }
    }

    class Second : First
    {
        public Second()
        {
            Console.WriteLine("Second constructor");
        }
        ~Second()
        {
            Console.WriteLine("Second destructor");
        }
    }

    class Third : Second
    {
        public Third()
        {
            Console.WriteLine("Third constructor");
        }
        ~Third()
        {
            Console.WriteLine("Third destructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (true) { 
                Third t = new Third();
            }
            Console.WriteLine("Done");
        }
    }
}
