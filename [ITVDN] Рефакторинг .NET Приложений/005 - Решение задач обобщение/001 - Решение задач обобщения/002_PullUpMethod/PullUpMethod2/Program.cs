using System;

// Pull Up Method (Подъем метода).

namespace PullUpMethod
{
    class Employee
    {
        protected string name = "Name";

        public void GetName()
        {
            Console.WriteLine(name);
        }
    }

    class Engineer : Employee
    {       
    }

    class Salesman : Employee
    {
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
