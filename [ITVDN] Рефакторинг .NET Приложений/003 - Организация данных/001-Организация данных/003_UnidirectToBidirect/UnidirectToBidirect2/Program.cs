using System;
using System.Collections.Generic;

// Change Unidirectional Association To Bidirectional
// (Замена однонаправленной связи двунаправленной).

namespace ChangeUnidirectionalAssociationToBidirectional
{
    class Order
    {
        Customer customer;
          
        public Customer GetCustomer()
        {
            return customer;
        }

        public void SetCustomer(Customer arg)
        {
            if (customer != null)
                customer.FriendOrders().Remove(this);

            customer = arg;

            if (customer != null)
                customer.FriendOrders().Add(this);
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
            arg.SetCustomer(this);
        }
    }

    class Program
    {
        static void Main()
        {
            Order order = new Order();
            Customer customer = new Customer();
            order.SetCustomer(customer);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
