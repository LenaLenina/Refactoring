using System;

// Introduce Explaining Variable (Введение поясняющей переменной).  138 - 139 стр.

namespace IntroduceExplainingVariable
{
    class Order
    {
        int quantity;
        int itemPrice;

        public Order(int quantity, int itemPrice)
        {
            this.quantity = quantity;
            this.itemPrice = itemPrice;
        }

        // Price = [базисная цена] - [скидка по количеству] + [поставка].
        public double Price()
        {
            double basePrice = quantity * itemPrice;               // Базисная цена

            return basePrice -
                Math.Max(0, quantity - 500) * itemPrice * 0.05 +   // Скидка по количеству
                Math.Min(basePrice * 0.1, 100);                    // Поставка
        }
    }

    class Program
    {
        static void Main()
        {
            Order order = new Order(5, 12);
            double result = order.Price();
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
