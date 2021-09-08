using System;

namespace Destructor
{
    public class Third : Second
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
}
