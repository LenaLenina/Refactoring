using System;

// Inline Method (Встраивание метода). 131 стр.

namespace InlineMethod
{
    class Program
    {
        int numberOfLateDeliveries = 3;

        public int GetRating()
        {
            return numberOfLateDeliveries > 5 ? 2 : 1;
        }

        static void Main()
        {
            int rating = new Program().GetRating();
            Console.WriteLine(rating);

            // Delay.
            Console.ReadKey();
        }
    }
}
