using System;

namespace ReadOnlyMod
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadOnlyMod Obj = new ReadOnlyMod(3);
            Obj.x = 1;
            Obj.print();
        }
    }
}
