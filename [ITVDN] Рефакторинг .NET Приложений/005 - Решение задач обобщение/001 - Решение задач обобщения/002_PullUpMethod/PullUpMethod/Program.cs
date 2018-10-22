using System;

// Pull Up Method (Подъем метода).

namespace PullUpMethod
{
    class Employee
    {
        protected string name = "Name";
    }

    class Engineer : Employee
    {
        public void GetName()
        {
            Console.WriteLine(name);
        }
    }

    class Salesman : Employee
    {
        public void GetName()
        {
            Console.WriteLine(name);
        }
    }

    class Program
    {
        static void Main()
        {

            // Delay.
            Console.ReadKey();
        }
    }
}
