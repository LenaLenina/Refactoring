using System;

// Extract Subclass (Выделение подкласса).

namespace ExtractSubclass
{
    class Car
    {
        protected int maxSpeed = 160;

        public virtual void StartToMove()
        {
            Console.WriteLine("Your vehicle starts to move. Your max speed = {0} km/h", maxSpeed);
        }
    }

    class SportCar : Car
    {
        private void TurnOnTurbo()
        {
            maxSpeed += 60;
        }

        public override void StartToMove()
        {
            TurnOnTurbo();
            base.StartToMove();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SportCar fastCar = new SportCar();

            fastCar.StartToMove();
        }
    }
}