using System;

// Remove Control Flag (Удаление управляющего флага).
// Замена простого управляющего флага оператором break.

namespace RemoveControlFlag
{
    class Program
    {
        static void CheckSecurity(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    break;
                }
                if (people[i].Equals("John"))
                {
                    SendAlert();
                    break;
                }
            }
        }

        static void SendAlert()
        {
            Console.WriteLine("Found!");
        }

        static void Main()
        {
            string[] people = { "Martin", "Kent", "Don", "John", "Jim" };

            CheckSecurity(people);

            // Delay.
            Console.ReadKey();
        }
    }
}
