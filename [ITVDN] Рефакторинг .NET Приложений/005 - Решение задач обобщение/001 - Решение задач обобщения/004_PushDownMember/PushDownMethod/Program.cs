using System;

// Push Down Method (Спуск метода). 
// Push Down Field (Спуск поля). 

namespace PushDownMethod
{
    class Employee
    {
        protected string quota;

        public string GetQuota()
        {
            return quota;
        }
    }

    class Salesman : Employee
    {
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
