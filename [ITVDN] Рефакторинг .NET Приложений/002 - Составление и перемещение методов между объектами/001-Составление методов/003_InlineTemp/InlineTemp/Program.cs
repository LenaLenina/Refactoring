using System;

// Inline Temp (Встраивание временной переменной). 132 стр.

namespace InlineTemp
{
    class Order
    {
        public double BasePrice()
        {
            return 1.2;
        }
    }

    class Program
    {
        static bool CheckPrice(Order anOrder)
        {
            double basePrice = anOrder.BasePrice();
            return basePrice > 1000;
        }

        static void Main()
        {
            Order order = new Order();
            bool result = CheckPrice(order);
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
