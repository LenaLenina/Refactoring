using System;
using System.Collections.Generic;

//  Replace Data Value With Object (Замена значения данных объектом). 186 стр.

namespace ReplaceDataValueWithObject
{
    class Order
    {
        private Customer customer;

        public Order(string customerName)
        {
            this.customer = new Customer(customerName);
        }

        public void SetCustomer(string customerName)
        {
            this.customer = new Customer(customerName);
        }

        public string GetCustomerName()
        {
            return this.customer.GetName();
        }
    }

    class Customer
    {
        readonly string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static int NumberOfOrdersFor(List<Order> collection, string customer)
        {
            int result = 0;

            foreach (var order in collection)
            {
                if (order.GetCustomerName().Equals(customer))
                {
                    result++;
                }
            }
            return result;
        }

        static void Main()
        {
            List<Order> orders = new List<Order>
            { 
                new Order("Martin"), new Order("Kent"), new Order("Grady") 
            };

            int number = NumberOfOrdersFor(orders, "Kent");
            Console.WriteLine(number);

            // Delay.
            Console.ReadKey();
        }
    }
}
