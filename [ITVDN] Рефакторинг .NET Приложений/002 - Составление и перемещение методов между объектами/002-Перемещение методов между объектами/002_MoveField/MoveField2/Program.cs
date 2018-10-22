using System;

// Move Field (Перемещение поля). 159 - 160 стр.

namespace MovieField
{
	class Account
	{
		private AccountType type;

		public Account(double interestRate)
		{
			this.type = new AccountType();
			this.type.InterestRate = interestRate;
		}

		public double InterestForAmountDays(double amount, int days)
		{
			return type.InterestRate * amount * days / 365;
		}
	}

	class AccountType
	{
		double interestRate;

		public double InterestRate
		{
			set { interestRate = value; }
			get { return interestRate; }
		}
	}

	class Program
	{
		static void Main()
		{
			Account account = new Account(5);
			double result = account.InterestForAmountDays(10, 2);
			Console.WriteLine(result);

			// Delay.
			Console.ReadKey();
		}
	}
}
