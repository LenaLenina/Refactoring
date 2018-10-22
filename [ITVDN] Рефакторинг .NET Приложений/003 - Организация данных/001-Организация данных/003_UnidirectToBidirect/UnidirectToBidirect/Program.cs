using System;

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
            this.customer = arg;
        }
    }

    class Customer
    {

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
