using System;

// Move Field (Перемещение поля). 159 стр.

namespace MovieField
{
    class Account
    {
        private AccountType type;
        private double interestRate; 

        public Account(double interestRate)
        {
            this.type = new AccountType();
            this.interestRate = interestRate;
        }

        public double InterestForAmountDays(double amount, int days)
        {
            return interestRate * amount * days / 365;
        }
    }

    class AccountType
    {
        
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
