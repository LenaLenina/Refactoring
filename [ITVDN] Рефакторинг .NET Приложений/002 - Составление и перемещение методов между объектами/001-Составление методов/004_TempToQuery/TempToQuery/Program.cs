using System;

// Replace Temp with Query (Замена временной переменной вызовом метода). 135 стр.

namespace ReplaceTempWithQuery
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

        public double GetPrice()
        {
            int basePrice = quantity * itemPrice;
            double discountFactor = 0;

            if (basePrice > 1000)
                discountFactor = 0.95;
            else
                discountFactor = 0.98;

            return basePrice * discountFactor;
        }
    }

    class Program
    {
        static void Main()
        {
            Order order = new Order(5, 12);
            double result = order.GetPrice();
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
