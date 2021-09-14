using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Audi : Vehicle
    {
        public Audi()
        {
            this.TopSpeed = 329.91f; //kmph
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
