using System;

namespace Refactoring
{
    class ChildrensPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }
    }
}
