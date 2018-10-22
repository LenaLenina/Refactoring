using System;

// Push Down Method (Спуск метода). 
// Push Down Field (Спуск поля). 

namespace PushDownMethod
{
    class Employee
    {
    }

    class Salesman : Employee
    {
        string quota;

        public string GetQuota()
        {
            return quota;
        }
    }

    class Engineer : Employee
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
