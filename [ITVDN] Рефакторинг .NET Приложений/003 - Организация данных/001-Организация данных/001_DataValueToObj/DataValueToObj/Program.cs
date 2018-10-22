using System;
using System.Collections.Generic;

//  Replace Data Value With Object (Замена значения данных объектом). 185 стр.

namespace ReplaceDataValueWithObject
{
	class Order
	{
		private string customer;

		public Order(string customer)
		{
			this.customer = customer;
		}

		public string Customer
		{
			get { return customer; }
			set { customer = value; }
		}
	}

	class Program
	{
		static int NumberOfOrdersFor(List<Order> collection, string customer)
		{
			int result = 0;

			foreach (var order in collection)
			{
				if (order.Customer.Equals(customer))
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
