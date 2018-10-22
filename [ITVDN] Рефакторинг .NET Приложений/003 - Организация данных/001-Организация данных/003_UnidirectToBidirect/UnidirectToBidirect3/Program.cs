using System;
using System.Collections.Generic;

// Change Unidirectional Association To Bidirectional
// (Замена однонаправленной связи двунаправленной).

namespace ChangeUnidirectionalAssociationToBidirectional
{
    class Order
    {
        List<Customer> customers = new List<Customer>();

        public List<Customer> FriendCustomers()
        {
            return customers;
        }

        public void AddCustomer(Customer arg)
        {
            arg.FriendOrders().Add(this);
            customers.Add(arg);
        }

        public void RemoveCustomer(Customer arg)
        {
            arg.FriendOrders().Remove(this);
            customers.Remove(arg);
        }
    }

    class Customer
    {
        List<Order> orders = new List<Order>();

        public List<Order> FriendOrders()
        {
            return orders;
        }

        public void AddOrder(Order arg)
        {
            arg.AddCustomer(this);
        }

        public void RemoveOrder(Order arg)
        {
            arg.RemoveCustomer(this);
        }
    }

    class Program
    {
        static void Main()
        {
            Order order = new Order();
            order.AddCustomer(new Customer());
            order.AddCustomer(new Customer());
            List<Customer> customers = order.FriendCustomers();

            Customer customer = new Customer();
            customer.AddOrder(new Order());
            customer.AddOrder(new Order());
            List<Order> orders = customer.FriendOrders();

            // Delay.
            Console.ReadKey();
        }
    }
}
