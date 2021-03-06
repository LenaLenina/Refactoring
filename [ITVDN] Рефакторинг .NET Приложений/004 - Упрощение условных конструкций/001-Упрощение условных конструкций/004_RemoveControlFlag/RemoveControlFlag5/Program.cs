﻿using System;

// Remove Control Flag (Удаление управляющего флага).

namespace Condition
{
    class CofeeMaker
    {
        private double GetCost()
        {
            while (true)
            {
                Console.WriteLine("Размеры стаканчиков кофе: 1 = Маленький, 2 = Большой");
                Console.Write("Пожалуйста, сделайте свой выбор: ");

                string coffeeSize = Console.ReadLine();

                switch (coffeeSize)
                {
                    case "1":
                        return 25;
                    case "2":
                        return 50;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуста выберите 1 или 2.");
                        break;
                }

                Console.WriteLine();
            }

            throw new Exception();
        }

        public void Start()
        {
            double cost = GetCost();

            Console.WriteLine("Внесите {0} копеек.", cost);
        }
    }

    class Program
    {
        static void Main()
        {
            new CofeeMaker().Start();

            // Delay.
            Console.ReadKey();
        }
    }
}
