using System;
using System.Collections.Generic;

namespace Refactoring
{
    /// <summary>
    /// Класс, представляющий клиента магазина.
    /// </summary>
    class Customer
    {
        // Поля

        private string name = null;
        private List<Rental> rentals = new List<Rental>();

        // Методы

        public Customer(string name)
        {
            this.name = name;
        }

        //  Использована техника Перемещения Метода (Move Method)
       
        /// <summary>
        /// Метод создающий отчет.
        /// </summary>
        /// <returns></returns>
        public string Statement()
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;
            string result = string.Format("Учет аренды для {0}: ", name);

            foreach (Rental rental in rentals)
            {
                double thisAmount = 0;

                // Определить сумму для каждой строки.
                thisAmount = rental.GetCharge();

                // Добавить очки для активного арендатора.
                frequentRenterPoints++;

                // Бонус за аренду новинки на два дня.
                if ((rental.Movie.PriceCode == Movie.NEW_RELEASE) && rental.DaysRented > 1)
                    frequentRenterPoints++;

                // Показать результаты для этой аренды
                result += "\t" + rental.Movie.Title + "\t" + thisAmount + "\n";
                totalAmount += thisAmount;
            }
            // Добавить нижний колонтитул
            result += "Сумма задолженности составляет " + totalAmount + "\n";
            result += "Вы заработали " + frequentRenterPoints + " очков за активность";
            return result;
        }
               
        // Свойства

        public Rental Rentals
        {
            set { this.rentals.Add(value); }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
