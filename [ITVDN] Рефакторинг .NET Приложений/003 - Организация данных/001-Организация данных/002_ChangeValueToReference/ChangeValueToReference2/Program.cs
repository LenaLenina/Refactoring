using System;
using System.Collections.Generic;

// Change Value To Reference (Замена значения ссылкой). 189 стр.

namespace ChangeValueToReference
{
	class Order
	{
		Customer customer;

		public Order(string customerName)
		{
			customer = Customer.Create(customerName);
		}

		public Customer Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		public string GetCustomerName()
		{
			return customer.Name;
		}
	}

	class Customer
	{
		readonly string name;

		private Customer(string name) { this.name = name; }
		public string Name { get { return this.name; } }
		public static Customer Create(string name) { return new Customer(name); }
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
				new Order("Martin"), new Order("Kent"), new Order("Grady"), new Order("Kent")
			};

			int number = NumberOfOrdersFor(orders, "Kent");
			Console.WriteLine(number);

			// Delay.
			Console.ReadKey();
		}
	}
}
