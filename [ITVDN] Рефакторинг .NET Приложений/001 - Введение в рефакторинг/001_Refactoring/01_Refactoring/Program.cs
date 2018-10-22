using System;

// TODO: Слабо спроектированная программа. (Не объектно-ориентированная)

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
            Customer customer = new Customer("Alex");
            Movie movie = new Movie("Matrix", 1);
            Rental rental = new Rental(movie, 2);

            customer.Rentals = rental;
            Console.WriteLine(customer.Statement());

            // Delay.
            Console.ReadKey();
        }
    }
}
