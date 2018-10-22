using System;

// Замена условной логики на полиморфизм.

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
            return movie.GetCharge(DaysRented);
        }

        /// <summary>
        /// Расчет бонусов зв аренду.
        /// </summary>
        /// <returns>Бонус за аренду</returns>
        public int GetFrequentRenterPoints()
        {
            return movie.GetFrequentRenterPoints(daysRented);
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
