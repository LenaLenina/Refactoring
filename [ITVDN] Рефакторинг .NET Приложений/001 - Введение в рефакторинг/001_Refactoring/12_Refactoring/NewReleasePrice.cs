using System;

namespace Refactoring
{
    class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        /// <summary>
        /// Расчет бонусов зв аренду.
        /// </summary>
        /// <param name="daysRented"></param>
        /// <returns>Бонус за аренду</returns>
        public override int GetFrequentRenterPoints(int daysRented) // замещение
        {
            return daysRented > 1 ? 2 : 1;
        }
    }
}
