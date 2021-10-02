using System;

namespace References
{
    class Program
    {
        static void Main(string[] args)
        {
            References obj = new References(100);
            obj.printNumber();
            References.changeReference(ref obj);
            obj.printNumber();
        }
    }
}
