using System;
using System.IO;

namespace Delegates
{
    class Program
    {
        // delegate are function references that can be used as callbacks
        public delegate void printString(string s);

        public static void printScreen(string s)
        {
            Console.WriteLine(s);
        }

        public static void printFile(string s)
        {
            FileStream fs = new FileStream("./temp.txt", FileMode.Append);
            StreamWriter sr = new StreamWriter(fs);
            sr.Write(s);
            sr.Flush();
            sr.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            printString ps1 = new printString(printScreen);
            printString ps2 = new printString(printFile);

            ps1("This is on screen");
            ps2("This is in a file");
        }
    }
}
