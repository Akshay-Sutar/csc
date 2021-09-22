using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BerettaM9 m9 = new BerettaM9("9mm");
            ColtM4 m4 = new ColtM4("5.56mm");

            m9.shoot();
            m4.shoot();
        }
    }
}
