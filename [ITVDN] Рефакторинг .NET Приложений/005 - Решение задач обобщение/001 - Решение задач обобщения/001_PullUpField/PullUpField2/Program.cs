using System;

// Pull Up Field (Подъем поля).

namespace PullUpField
{
    class Employee
    {
        protected string name;
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
