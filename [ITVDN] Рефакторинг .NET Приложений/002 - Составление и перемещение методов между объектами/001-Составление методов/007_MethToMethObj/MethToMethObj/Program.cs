using System;

// Replace Method With Method Object (Замена метода объектом методов). 149 стр.

namespace ReplaceMethodWithMethodObject
{
    class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            int importantValue1 = (inputVal * quantity) + Delta();
            int importantValue2 = (inputVal * yearToDate) + 100;
             
            if ((yearToDate - importantValue1) > 100)
                importantValue2 = -20;

            int importantValue3 = importantValue2 * 7;
            // и т.д.
            return importantValue3 - 2 * importantValue1;
        }

        int Delta()
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
