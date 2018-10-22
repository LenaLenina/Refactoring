using System;

// Замена рефакторинга Introduce Explaining Variable (Введение поясняющей переменной) 
// на рефакторинг ExtractMethod (Выделение метода). 139 - 140 стр.


namespace ExtractMethod
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
            return BasePrice() - QuantityDiscount() + Shipping();
        }

        // Базисная цена
        private int BasePrice()
        {
            return quantity * itemPrice;
        }

        // Скидка по количеству
        private double QuantityDiscount()
        {
            return Math.Max(0, quantity - 500) * itemPrice * 0.05;
        }

        // Поставка
        private double Shipping()
        {
            return Math.Min(quantity * itemPrice * 0.1, 100);
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
