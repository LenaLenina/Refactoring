using System;

// Extract Subclass (Выделение подкласса).

namespace ExtractSubclass
{
    class Car
    {
        bool isSportCar;
        int maxSpeed = 160;

        public Car(bool isSportCar)
        {
            this.isSportCar = isSportCar;
        }

        public void StartToMove()
        {
            if (isSportCar)
            {
                TurnOnTurbo();
            }

            Console.WriteLine("Your vehicle starts to move. Your max speed = {0} km/h", maxSpeed);
        }

        private void TurnOnTurbo()
        {
            maxSpeed += 60;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car fastCar = new Car(false);

            fastCar.StartToMove();
        }
    }
}