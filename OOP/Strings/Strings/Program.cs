using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eren = "Eren Yeager";
            string Mikasa = new string("Mikasa");
            char[] name = { 'A', 'r', 'm', 'i', 'n' };
            string Armin = new string(name);

            // string is alias for System.String and is same

            string quote = "My name's \"Bond\", James Bond";

            string catchPhrase = @"Sasageyo!!!. Erwin Smith's last battle cry.";

            string passage = @"this is \
                new \
                line
            ";

            string characters = Eren + ", " + Mikasa + ", and " + Armin;

            Console.WriteLine(Eren);
            Console.WriteLine(Mikasa);
            Console.WriteLine(Armin);
            Console.WriteLine(quote);
            Console.WriteLine(catchPhrase);
            Console.WriteLine(passage);
            Console.WriteLine(characters);
        }
    }
}
