using System;

// Move Method (Перемещение метода). 156 - 157 стр.
// Данный рефакторинг иллюстрирует класс банковского счета.

namespace MoveMethod
{
	class Account
	{
		int daysOverdrawn = 0;
		AccountType type;

		public Account()
		{
			this.type = new AccountType();
		}

		public double BankCharge()
		{
			double result = 4.5;
			if (daysOverdrawn > 0) { result += type.OverdraftCharge(daysOverdrawn); }
			return result;
		}
	}

	class AccountType
	{
		public bool IsPremium()
		{
			return true;
		}

		public double OverdraftCharge(int daysOverdrawn)
		{
			if (this.IsPremium())
			{
				double result = 10;
				if (daysOverdrawn > 7)
				{
					result += (daysOverdrawn - 7) * 0.85;
				}
				return result;
			}
			else
			{
				return daysOverdrawn * 1.75;
			}
		}
	}

	class Program
	{
		static void Main()
		{
			Account account = new Account();
			double result = account.BankCharge();
			Console.WriteLine(result);

			// Delay.
			Console.ReadKey();
		}
	}
}
