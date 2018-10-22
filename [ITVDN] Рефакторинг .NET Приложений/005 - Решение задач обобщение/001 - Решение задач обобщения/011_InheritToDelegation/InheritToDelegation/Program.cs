using System;

// Replace Inheritance With Delegation (Замена наследования делегированием).

namespace ReplaceInheritanceWithDelegation
{
    class Engine
    {
        public void IncreaseTurns()
        {
        }
    }

    class Car : Engine
    {
        public void ReleaseClutch()
        {
        }
    }

    class Program
    {
        static void Main()
        {

            Car car = new Car();

            car.IncreaseTurns();
            car.ReleaseClutch();

            // Delay.
            Console.ReadKey();
        }
    }
}
