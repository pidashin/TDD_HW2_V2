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
            var discounts = new List<double> { 1, 1, 0.95, 0.9, 0.8, 0.75};

            var source = books.GroupBy(item => item.Episode).Select(item => new { Count = item.Count(), Price = item.ToList()[0].price});

            var groupCount = source.Select(item => item.Count).Distinct().OrderBy(item => item);

            double result = 0;
            int countSum = 0;
            groupCount.ToList().ForEach(c =>
            {
                source = source.Where(temp => temp.Count >= c);
                var discount = discounts[source.Count()];
                result += source.Sum(temp => temp.Price * discount * (c - countSum));
                countSum = c;
            });

            return result;
        }
    }
}
