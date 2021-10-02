using System;

namespace References
{
    class References
    {
        private int _number;

        public References(int number)
        {
            _number = number;
        }

        public void printNumber()
        {
            Console.WriteLine($"No is {_number}");
        }

        public static void changeReference(ref References obj) {
            obj = new References(10); 
        }
    }
}
