using System;

namespace Destructor
{
    public class First
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
}
