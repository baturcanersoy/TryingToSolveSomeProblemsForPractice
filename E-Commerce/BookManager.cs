using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    class BookManager
    {
        public void CurrentPrice(Books book)
        {
           book.CurrentPrice =( (book.OrginalPrice) * ( 100-(book.DiscountRate) ) ) / 100;
        }
    }
}
