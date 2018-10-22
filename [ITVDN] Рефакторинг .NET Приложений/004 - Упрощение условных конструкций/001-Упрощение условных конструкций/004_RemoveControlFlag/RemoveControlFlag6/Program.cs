using System;

// Remove Control Flag (Удаление управляющего флага). 252 стр.
// Использование оператора return, возвращающего значение управляющего флага.

namespace RemoveControlFlag
{
    class Program
    {
        static void CheckSecurity(string[] people)
        {
            string found = FoundMiscreant(people);
            SomeLaterCode(found);
        }

        private static string FoundMiscreant(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don"))
                {
                    SendAlert();
                    return "Don";
                }
                if (people[i].Equals("John"))
                {
                    SendAlert();
                    return "John";
                }
            }
            return " ";
        }

        private static void SomeLaterCode(string found)
        {
            Console.WriteLine(found);
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
