using System;

// Replace Temp with Query (Замена временной переменной вызовом метода). 136 - 137 стр.

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
            return BasePrice() * DiscountFactor();
        }

        private int BasePrice()
        {
            return quantity * itemPrice;
        }

        private double DiscountFactor()
        {
            if (BasePrice() > 1000)
                return 0.95;
            else
                return 0.98;
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
