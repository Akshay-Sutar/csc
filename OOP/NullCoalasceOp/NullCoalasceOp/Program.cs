using System;

namespace NullCoalasceOp
{
    class Program
    {
        static void Main(string[] args)
        {
            NullCoalesceOp a = new NullCoalesceOp(5);
            NullCoalesceOp b = new NullCoalesceOp(null);
            Console.WriteLine("a value is "+a.getValue());
            Console.WriteLine("b value is "+b.getValue());
        }
    }
}
