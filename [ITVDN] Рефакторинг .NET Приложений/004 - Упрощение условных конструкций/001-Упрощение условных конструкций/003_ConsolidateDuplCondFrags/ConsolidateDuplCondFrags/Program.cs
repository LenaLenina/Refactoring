using System;

// Consolidate Duplicate Conditional Fragments (Консолидация дублирующихся условных фрагментов).

namespace ConsolidateDuplicateConditionalFragments
{
    class Program
    {
        static void ModifyAndShowValue(int value)
        {
            if (value > 0)
            {
                value++;
                Console.WriteLine(value);
            }
            else if (value < 0)
            {
                value--;
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
