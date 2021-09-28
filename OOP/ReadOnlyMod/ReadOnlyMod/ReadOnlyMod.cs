using System;
namespace ReadOnlyMod
{
    class ReadOnlyMod
    {
        public int x;
        public readonly int y = 2;
        public readonly int z;

        public ReadOnlyMod(int z)
        {
            this.z = z;
        }

        public void print()
        {
            Console.WriteLine($" x = {x}");
            Console.WriteLine($" y = {y}");
            Console.WriteLine($" z = {z}");
        }
    }
}
