using System;
using System.Text;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // allows to mutate a string and save memory space
            StringBuilder sb = new StringBuilder("This is a line");

            StringBuilder sb1 = new StringBuilder(15); // max 5 characters
            sb1.AppendLine("Total Overdose");
            Console.WriteLine($"string is : {sb1.ToString()}");
            Console.WriteLine($"string length is {sb1.Length}");

            sb1.AppendLine("Call of Duty");
            sb1.AppendLine("Battlefield");

            Console.WriteLine($"string is : {sb1.ToString()}");
            Console.WriteLine($"string length is {sb1.Length}");

            // insert new line
            sb.Insert(9," dank");
            Console.WriteLine($"line after inserting : {sb.ToString()}");

            // remove
            sb.Remove(9,5);
            Console.WriteLine($"line after remving : {sb.ToString()}");
        }
    }
}
