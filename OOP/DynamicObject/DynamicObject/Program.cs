using System;
using System.Dynamic;

namespace DynamicObject
{
    class Program
    {
        /*
            create dynamic members
         */
        static void Main(string[] args)
        {
            dynamic Employee = new ExpandoObject();

            Employee.name = "James Bond";
            Employee.age = 35;

            dynamic Employer = new ExpandoObject();
            Employer.name = "MI6";
            Employer.age = 105;

            printObj(Employee);
            printObj(Employer);
        }

        public static void printObj(dynamic obj)
        {
            Console.WriteLine($"name is {obj.name} and age is {obj.age}");
        }
    }
}
