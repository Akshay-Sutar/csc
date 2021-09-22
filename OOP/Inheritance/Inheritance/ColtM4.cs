using System;

namespace Inheritance
{
    class ColtM4 : Gun
    {
        public ColtM4(string ammo) : base(ammo)
        {

        }

        public override void shoot()
        {
            Console.WriteLine("M4 goes brrrr!!!");
        }
    }
}
