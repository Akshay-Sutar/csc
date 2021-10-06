using System;

namespace Outkeyword
{
    /*
        out keyword is used to pass data by reference. 
        similar to ref keyword but the data need not be initialized before passing to method.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int speed;
            OutKeyword obj = new OutKeyword();
            obj.setSpeed(out speed);
            Console.WriteLine($"speed is set to {speed}");
        }
    }
}
