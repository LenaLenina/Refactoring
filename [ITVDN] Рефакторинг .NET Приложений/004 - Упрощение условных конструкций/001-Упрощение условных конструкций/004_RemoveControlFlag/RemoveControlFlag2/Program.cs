using System;
using System.Data.SqlClient;

// Remove Control Flag (Удаление управляющего флага).

namespace RemoveControlFlag
{
    class Program
    {
        static void StartGame()
        {
            Console.WriteLine("Угадайте задуманый цвет.");

            while (true)
            {
                string supposedColor = Console.ReadLine();

                if (supposedColor == "красный")
                {
                    Console.WriteLine("Вы угадали!");

                    break;
                }
                else
                {
                    Console.WriteLine("Вы не угадали, попробуйте еще раз");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            StartGame();
        }
    }
}
