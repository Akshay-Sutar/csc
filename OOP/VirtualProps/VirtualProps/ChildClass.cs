using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualProps
{
    class ChildClass: BaseClass
    {
        public override string name
        {
            get 
            {
                return name;
            }

            set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    name = "unknown";
                } else
                {
                    name = value;
                }
            }
        }
    }
}
