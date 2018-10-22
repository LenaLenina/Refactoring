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

    class Car
    {
        Engine engine = new Engine();

        public void IncreaseTurns()
        {
            engine.IncreaseTurns();
        }

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
