using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                Third t = new();
            }
            Console.WriteLine("Done");
        }
    }
}
