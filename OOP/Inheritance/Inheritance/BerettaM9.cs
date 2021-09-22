using System;

namespace Inheritance
{
    class BerettaM9 : Gun
    {
        public BerettaM9(string ammo) : base(ammo)
        {

        }

        public override void shoot()
        {
            Console.WriteLine("M9 goes pew!");
        }
    }
}
