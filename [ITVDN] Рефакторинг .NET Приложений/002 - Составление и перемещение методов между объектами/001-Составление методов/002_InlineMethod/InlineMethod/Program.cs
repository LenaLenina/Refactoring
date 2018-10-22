using System;

// Inline Method (Встраивание меода). 131 стр.

namespace InlineMethod
{
    class Program
    {
        int numberOfLateDeliveries = 3;

        public int GetRating()
        {
            return MoreThenFiveLateDeliveries() ? 2 : 1;
        }

        bool MoreThenFiveLateDeliveries()
        {
            return numberOfLateDeliveries > 5;
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
