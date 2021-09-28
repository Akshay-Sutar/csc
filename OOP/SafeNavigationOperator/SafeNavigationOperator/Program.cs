using System;

namespace SafeNavigationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            SafeNavigationOperator person = new SafeNavigationOperator("AAS",null,"ABC");
            Console.WriteLine("First Name is :"+person?.Fname);
            Console.WriteLine("Second Name is :"+person?.Mname);
            Console.WriteLine("Last Name is :"+person?.Lname);

            SafeNavigationOperator person2 = null;
            Console.WriteLine("First Name is :" + person2?.Fname);
            Console.WriteLine("Second Name is :" + person2?.Mname);
            Console.WriteLine("Last Name is :" + person2?.Lname);
        }
    }
}
