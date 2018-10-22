using System;

namespace Refactoring
{
    /// <summary>
    /// Класс, который предоставляет данные о фильме.
    /// </summary>
    class Movie
    {
        // Поля

        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;
        public const int CHILDRENS = 2;

        private string title = null;
        private int priceCode = 0;

        Price price = null;

        // Методы

        public Movie(string title, int priceCode)
        {
            this.title = title;
            PriceCode = priceCode;
        }

        /// <summary>
        /// Определение суммы для каждой строки.
        /// </summary>
        /// <param name="daysRented"></param>
        /// <returns>Сумма для строки.</returns>
        public double GetCharge(int daysRented)
        {
            double result = 0;

            // Определить сумму для каждой строки.
            switch (PriceCode)
            {
                case Movie.REGULAR:
                    {
                        result += 2;
                        if (daysRented > 2)
                            result += (daysRented - 2) * 1.5;
                        break;
                    }
                case Movie.NEW_RELEASE:
                    {
                        result += daysRented * 3;
                        break;
                    }
                case Movie.CHILDRENS:
                    {
                        result += 1.5;
                        if (daysRented > 3)
                            result += (daysRented - 3) * 1.5;
                        break;
                    }
            }
            return result;
        }

        /// <summary>
        /// Расчет бонусов зв аренду.
        /// </summary>
        /// <param name="daysRented"></param>
        /// <returns>Бонус за аренду</returns>
        public int GetFrequentRenterPoints(int daysRented)
        {
            // Бонус за аренду новинки на два дня.
            if ((PriceCode == Movie.NEW_RELEASE) && daysRented > 1)
                return 2;
            else
                return 1;
        }

        // Свойства

        public int PriceCode
        {
            get { return this.price.GetPriceCode(); }
            set
            {
                switch (value)
                {
                    case REGULAR:
                        {
                            price = new RegularPrice();
                            break;
                        }
                    case CHILDRENS:
                        {
                            price = new ChildrensPrice();
                            break;
                        }
                    case NEW_RELEASE:
                        {
                            price = new NewReleasePrice();
                            break;
                        }
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public string Title
        {
            get { return this.title; }
        }
    }
}
