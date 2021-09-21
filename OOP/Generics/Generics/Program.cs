using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stringStack = new Stack<string>();
            Stack<int> integerStack = new Stack<int>();

            stringStack.push("Hasta");
            stringStack.push("la");
            stringStack.push("Vista");
            stringStack.print();
            stringStack.pop();
            stringStack.print();

            integerStack.push(3);
            integerStack.push(1);
            integerStack.push(4);
            integerStack.print();
            integerStack.pop();
            integerStack.print();

        }
    }
}
