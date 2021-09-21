using System;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFunctions obj = new LocalFunctions("Jonathan", "Joestar");
            Console.WriteLine(obj.speakName());
        }
    }
}
