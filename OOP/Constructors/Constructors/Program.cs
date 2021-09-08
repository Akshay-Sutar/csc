using System;

namespace Constructors
{
    class Program
    {
        public static int range;
        public int value;

        static Program()
        {
            range = 15;
        }

        public Program(int value) {
            this.value = value;
        }

        public Program(Program p) {
            this.value = p.value;
        }

        static void Main(string[] args)
        {
            Program p1 = new Program(10);
            Program p2 = new Program(p1);
            p2.value = 20;

            Console.WriteLine($"static value is {Program.range}");
            Console.WriteLine($"p1 value = {p1.value}");
            Console.WriteLine($"p2 value = {p2.value}");
        }
    }
}
