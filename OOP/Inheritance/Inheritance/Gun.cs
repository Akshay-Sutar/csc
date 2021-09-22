using System;

namespace Inheritance
{
    class Gun
    {
        private string _ammo;
        public Gun(string ammo)
        {
            _ammo = _ammo;
        }

        public virtual void shoot()
        {
            Console.WriteLine("pew pew");
        }
    }
}
