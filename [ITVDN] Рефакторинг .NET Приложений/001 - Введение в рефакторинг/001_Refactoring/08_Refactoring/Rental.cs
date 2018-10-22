using System;

namespace Refactoring
{
    /// <summary>
    /// Класс, представляющий данные о прокате фильма.
    /// </summary>
    class Rental
    {
        // Поля

        private Movie movie = null;
        private int daysRented = 0;

        // Методы

        public Rental(Movie movie, int daysRented)
        {
            this.movie = movie;
            this.daysRented = daysRented;
        }

        /// <summary>
        /// Определение суммы для каждой строки.
        /// </summary>
        /// <returns>Сумма для строки.</returns>
        public double GetCharge()
        {
            double result = 0;

            // Определить сумму для каждой строки.
            switch (Movie.PriceCode)
            {
                case Movie.REGULAR:
                    {
                        result += 2;
                        if (DaysRented > 2)
                            result += (DaysRented - 2) * 1.5;
                        break;
                    }
                case Movie.NEW_RELEASE:
                    {
                        result += DaysRented * 3;
                        break;
                    }
                case Movie.CHILDRENS:
                    {
                        result += 1.5;
                        if (DaysRented > 3)
                            result += (DaysRented - 3) * 1.5;
                        break;
                    }
            }
            return result;
        }

        /// <summary>
        /// Расчет бонусов зв аренду.
        /// </summary>
        /// <returns>Бонус за аренду</returns>
        public int GetFrequentRenterPoints()
        {
            // Бонус за аренду новинки на два дня.
            if ((movie.PriceCode == Movie.NEW_RELEASE) && DaysRented > 1)
                return 2;
            else
                return 1;
        }

        // Свойства

        public Movie Movie
        {
            get { return this.movie; }
        }

        public int DaysRented
        {
            get { return this.daysRented; }
        }
    }
}
