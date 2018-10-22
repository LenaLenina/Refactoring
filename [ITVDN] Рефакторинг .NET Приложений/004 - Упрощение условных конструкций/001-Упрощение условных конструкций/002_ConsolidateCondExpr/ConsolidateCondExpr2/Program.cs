using System;

// Consolidate Conditional Expression (Консолидация условного выражения). 

namespace ConsolidateConditionalExpression
{
    class Program
    {
        static int fieldToCheck;

        static bool IsFieldToCheckNegative()
        {
            if (fieldToCheck > 0 || fieldToCheck == 0)
                return false;

            if (fieldToCheck < 0)
                return true;

            throw new ArgumentException();
        }

        static void Main(string[] args)
        {
            fieldToCheck = -1;

            Console.WriteLine(IsFieldToCheckNegative());
        }
    }
}
