using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    public class HarryPotterCart
    {
        public double CountPrice(List<Book> books)
        {
            double discount = 1;
            if (books.Count >= 2)
                discount = 0.95;

            return books.Sum(item => item.price * discount);
        }
    }
}
