using System;

// TODO: Слабо спроектированная программа. (Не объектно ориентированная)

// Программа расчитывает и выводит отчет об оплате клиентом услуг в магазине видеопроката.
// Программе сообщается, какие фильмы брал в прокате клиент и на какой срок. 
// После этого программа рассчитывает сумму платежа исходя из продолжительности проката и типа фильма.
// Фильмы бывают трех типов: обычные, детские и новинки. Помимо расчета суммы оплаты начисляются бонусы 
// в зависимости от того, является ли фильм новым.

namespace Refactoring
{
    class Program
    {
        static void Main()
        {
            Customer[] customers = { new Customer("Alex"), new Customer("Ivan"), new Customer("Serg") };
            Movie[] movies = { new Movie("Matrix", 1), new Movie("Avatar", 0), new Movie("Titanik", 2) };
                       
            customers[0].Rentals = new Rental(movies[0], 1);
            customers[1].Rentals = new Rental(movies[0], 2);
            customers[2].Rentals = new Rental(movies[1], 1);
            customers[1].Rentals = new Rental(movies[2], 2);
            customers[2].Rentals = new Rental(movies[1], 3);

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Statement());
                Console.WriteLine(new string('_', 55));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
