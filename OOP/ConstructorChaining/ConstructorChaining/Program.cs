using System;

namespace ConstructorChaining
{
    class Base {
        public int b;
        public Base(int b)
        {
            this.b = b;
        }
    }

    class Child : Base {
        int c;
        public Child(int c) : base(0) {
            this.c = c;
        }

        public Child(int c, int b) : this (c){
            this.b = b;
        }

        public override string ToString()
        {
            return $" b = {this.b} , c = {this.c}";
        }
    }

    class Program
    {
        public int x, y;

        public Program(int x)
        {
            this.x = x;
        }

        // construct is chained
        public Program(int x, int y) : this(x)
        {
            this.y = y;
        }

        public Program(int x, int y, int z) : this(x , y)
        {
            this.y = y;
        }

        public override string ToString()
        {
            return $" x = {this.x} , y = {this.y}";
        }
        static void Main(string[] args)
        {
            Program p = new Program(1,2);
            Child c = new Child(3, 4);

            Console.WriteLine(p.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
