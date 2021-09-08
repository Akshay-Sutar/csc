using System;

namespace Statics
{
    public class Count
    {
        // Static fields are always Generation3
        // and collected after app exits/crashes.
        private static int _counter = 0;
        public const int THRESHOLD = 3;

        public Count()
        {
            if (_counter + 1 > THRESHOLD)
            {
                throw new Exception($"Cannot create more than {THRESHOLD} objects.");
            }

            _counter++;
            Console.WriteLine(_counter);
        }
    }
}
