using System;

namespace ParamKeyword
{
    class ParamKeyword
    {
        public void printList(params object[] list)
        {
            for (int i = 0; i < list.Length; ++i)
            {
                Console.WriteLine($"item at {i} is {list[i]}");
            }
        }
    }
}
