using System;

// Replace Nested Conditional With Guard Clauses (Замена вложенных условных операторов граничным оператором).

namespace ReplaceNestedConditionalWithGuardClauses
{
    class Program
    {
        static bool isDead = false;
        static bool isSeparated = false;
        static bool isRetired = false;

        static double GetPayAmount()
        {
            double result = 0;
            if (isDead)
                result = DeadAmount();
            else
            {
                if (isSeparated)
                    result = SeparatedAmount();
                else
                {
                    if (isRetired)
                        result = RetiredAmount();
                    else
                        result = NormalPayAmount();
                }
            }
            return result;
        }

        private static double NormalPayAmount()
        {
            return 1;
        }

        private static double RetiredAmount()
        {
            return 2;
        }

        private static double SeparatedAmount()
        {
            return 3;
        }

        private static double DeadAmount()
        {
            return 4;
        }

        static void Main()
        {

            // Delay.
            Console.ReadKey();
        }
    }
}
