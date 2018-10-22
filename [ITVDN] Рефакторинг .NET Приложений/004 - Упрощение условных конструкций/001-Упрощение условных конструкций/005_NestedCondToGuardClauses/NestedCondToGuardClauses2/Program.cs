using System;

// Replace Nested Conditional With Guard Clauses (Замена вложенных условных операторов граничным оператором).

namespace ReplaceNestedConditionalWithGuardClauses
{
	class Program
	{
		static bool isDead = false;
		static bool isSeparated = false;
		static bool isRetired = false;

		//static double GetPayAmount()
		//{
		//    if (isDead)
		//        return DeadAmount();
		//    else
		//    {
		//        if (isSeparated)
		//            return SeparatedAmount();
		//        else
		//        {
		//            if (isRetired)
		//                return RetiredAmount();
		//            else
		//                return NormalPayAmount();
		//        }
		//    }
		//}

		static double GetPayment()
		{
			if (isDead) { return DeadAmount(); }
			if (isSeparated) { return SeparatedAmount(); }
			if (isRetired) { return RetiredAmount(); }
			
            return NormalPayAmount();
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
