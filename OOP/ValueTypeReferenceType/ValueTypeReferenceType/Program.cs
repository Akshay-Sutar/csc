using System;

namespace ValueTypeReferenceType
{
    /*
        Value type is a variable contains an instance.
        Reference type contains a reference of an instance.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Point p1,p2;
            p1 = new Point(1,2);
            Console.WriteLine(p1.ToString());
            p1.swap();
            Console.WriteLine(p1.ToString());
            p2 = p1;
            p2.X = 100;
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
