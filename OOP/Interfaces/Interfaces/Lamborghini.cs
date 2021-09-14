using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Lamborghini : Vehicle
    {
        public Lamborghini()
        {
            this.TopSpeed = 325; //kmph
            this.CurrentSpeed = 0.0f;
        }
        public float TopSpeed { get; set; }
        public float CurrentSpeed { get; set; }
        public void accelerate()
        {
            this.CurrentSpeed += 1.0f;
        }
        public void brake()
        {
            this.CurrentSpeed = 0;
        }
    }
}
