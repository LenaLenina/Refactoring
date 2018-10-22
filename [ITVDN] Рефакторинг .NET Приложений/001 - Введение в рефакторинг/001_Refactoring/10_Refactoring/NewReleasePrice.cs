using System;

namespace Refactoring
{
    class NewReleasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }
    }
}
