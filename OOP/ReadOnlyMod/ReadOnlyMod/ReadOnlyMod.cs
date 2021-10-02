using System;
namespace ReadOnlyMod
{
    class ReadOnlyMod
    {
        // read only is run time constants that can be initialized at declaration or in constructor and so can have different values based on constructor.
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
