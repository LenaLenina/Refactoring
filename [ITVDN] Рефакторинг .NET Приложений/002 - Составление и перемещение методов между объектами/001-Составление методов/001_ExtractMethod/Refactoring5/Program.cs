﻿using System;
using System.Collections.Generic;

// Выделение метода (Method Extraction). 129 стр.
// Присваивание нового значения локальной переменной.

namespace Refactoring
{
    class Order
    {
        public double GetAmount()
        {
            return new Random().Next(1, 5);
        }
    }

    class Program
    {
        string name = "Martin";

        List<Order> orders = new List<Order> 
        {
            new Order(), 
            new Order(), 
            new Order() 
        };

        public void PrintOwning(double previousAmount)
        {
            double outstanding = previousAmount * 1.2;

            PrintBanner();

            // Расчет задолженности.
            foreach (Order order in orders)
            {
                outstanding += order.GetAmount();
            }

            PrintDetails(outstanding);
        }

        private void PrintDetails(double outstanding)
        {
            // Вывод деталей
            Console.WriteLine("Имя {0}", name);
            Console.WriteLine("Сумма {0}", outstanding);
        }

        private static void PrintBanner()
        {
            // Вывод баннера.
            Console.WriteLine(new string('*', 25));
            Console.WriteLine("Задолженность клиента.");
            Console.WriteLine(new string('*', 25));
        }

        static void Main()
        {
            Program program = new Program();
            program.PrintOwning(10.0);

            // Delay.
            Console.ReadKey();
        }
    }
}
