using System;

namespace Destructor
{
    public class Second : First
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
}
