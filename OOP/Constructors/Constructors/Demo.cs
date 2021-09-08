using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Demo
    {
        public static int Range { get; set; }
        public int Value { get; set; }

        static Demo()
        {
            Range = 15;
        }

        public Demo(int value)
        {
            this.Value = value;
        }

        public Demo(Demo p)
        {
            this.Value = p.Value;
        }
    }
}
