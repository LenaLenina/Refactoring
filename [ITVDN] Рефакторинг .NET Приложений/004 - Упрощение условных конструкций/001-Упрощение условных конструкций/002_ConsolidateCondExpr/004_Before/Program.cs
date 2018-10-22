using System;

// Consolidate Conditional Expression (Консолидация условного выражения). 

namespace ConsolidateConditionalExpression
{
    class Program
    {
        static int firstFieldToCheck;
        static int secondFieldToCheck;

        static bool IsBothFieldsNegative()
        {
            if ((firstFieldToCheck < 0) && (secondFieldToCheck < 0))
                return true;

            return false;
        }

        static void Main(string[] args)
        {

        }
    }
}
