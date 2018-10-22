using System;
using System.Collections.Generic;

// Выделение метода (Method Extraction). 126 стр.

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

        public void PrintOwning()
        {
            double outstanding = 0.0;

            // Вывод баннера.
            Console.WriteLine(new string('*', 25));
            Console.WriteLine("Задолженность клиента.");
            Console.WriteLine(new string('*', 25));

            // Расчет задолженности.
            foreach (Order order in orders)
            {
                outstanding += order.GetAmount();
            }

            // Вывод деталей
            Console.WriteLine("Имя  : {0}", name);
            Console.WriteLine("Сумма: {0}", outstanding);
        }

        static void Main()
        {
            Program program = new Program();
            program.PrintOwning();

            // Delay.
            Console.ReadKey();
        }
    }
}
