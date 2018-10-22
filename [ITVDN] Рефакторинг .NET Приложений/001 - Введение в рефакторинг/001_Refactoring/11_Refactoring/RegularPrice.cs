using System;

namespace Refactoring
{
    class RegularPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }
    }
}
