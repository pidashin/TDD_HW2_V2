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
            var discounts = new List<double> { 1, 1, 0.95, 0.9 };
            var discount = discounts[books.Count()];
            return books.Sum(item => item.price * discount);
        }
    }
}
