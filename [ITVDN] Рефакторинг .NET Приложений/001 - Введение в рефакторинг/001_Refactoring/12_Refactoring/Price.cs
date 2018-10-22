using System;

namespace Refactoring
{
    abstract class Price
    {
        public abstract int GetPriceCode();
        public abstract double GetCharge(int daysRented);

        /// <summary>
        /// Расчет бонусов зв аренду.
        /// </summary>
        /// <param name="daysRented"></param>
        /// <returns>Бонус за аренду</returns>
        public virtual int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}
