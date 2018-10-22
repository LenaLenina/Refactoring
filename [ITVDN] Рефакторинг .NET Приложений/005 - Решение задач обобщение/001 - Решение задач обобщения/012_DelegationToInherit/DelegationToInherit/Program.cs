using System;

// Replace Delegation With Inheritance (Замена делегирования наследованием).

namespace ReplaceDelegationWithInheritance
{
    class Employee : Person
    {
        public override string ToString()
        {
            return "Emp " + GetLastName();
        }
    }

    class Person
    {
        string name;

        public string GetName()
        {
            return name;
        }

        internal void SetName(string arg)
        {
            name = arg;
        }

        internal string GetLastName()
        {
            throw new NotImplementedException();
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
