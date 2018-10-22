using System;
using System.Collections.Generic;

// Change Value To Reference (Замена значения ссылкой). 190 - 191 стр.

namespace ChangeValueToReference
{
    class Order
    {
        Customer customer;

        public Order(string customerName)
        {
            customer = Customer.GetNamed(customerName);
        }

        public void SetCustomer(string customerName)
        {
            this.customer = Customer.GetNamed(customerName);
        }

        public string GetCustomerName()
        {
            return customer.GetName();
        }
    }

    class Customer
    {
        readonly string name;
        static Dictionary<string, Customer> instances = new Dictionary<string, Customer>();

        private Customer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public static Customer GetNamed(string name)
        {
            Customer customer = null;
            instances.TryGetValue(name, out customer);
            return customer;
        }

        public static void LoadCustomers()
        {
            new Customer("Lemon Car Hire").Store();
            new Customer("Associated Coffee Machines").Store();
            new Customer("Bilston Gasworks").Store();
        }

        private void Store()
        {
            instances.Add(this.GetName(), this);
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
            
            // Delay.
            Console.ReadKey();
        }
    }
}
