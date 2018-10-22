using System;

// Replace Method With Method Object (Замена метода объектом методов). 151 стр.

namespace ReplaceMethodWithMethodObject
{
    class Gamma
    {
        Account account;
        int inputVal;
        int quantity;
        int yearToDate;
        int importantValue1;
        int importantValue2;
        int importantValue3;

        public Gamma(Account source, int inputVal, int quantity, int yearToDate)
        {
            this.account = source;
            this.inputVal = inputVal;
            this.quantity = quantity;
            this.yearToDate = yearToDate;
        }

        public int Compute()
        {
            importantValue1 = (inputVal * quantity) + account.Delta();
            importantValue2 = (inputVal * yearToDate) * 100;
            ImportantThing(); // Использован рефакторинг Extract Method (Выделение метода).
            importantValue3 = importantValue2 * 7;
            // и т.д.
            return importantValue3 - 2 * importantValue1;
        }

        private void ImportantThing()
        {
            if ((yearToDate - importantValue1) > 100)
                importantValue2 = -20;
        }
    }

    class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            return new Gamma(this, inputVal, quantity, yearToDate).Compute();
        }

        public int Delta()
        {
            return 1;
        }
    }

    class Program
    {
        static void Main()
        {
            Account account = new Account();
            int result = account.Gamma(1, 2, 2000);
            Console.WriteLine(result);

            // Delay.
            Console.ReadKey();
        }
    }
}
