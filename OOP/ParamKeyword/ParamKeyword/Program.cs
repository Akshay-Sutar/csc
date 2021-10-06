using System;

namespace ParamKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamKeyword obj = new ParamKeyword();
            obj.printList(1, 2, 3, 4, 5);
            obj.printList("this","is","a","test");
        }
    }
}
