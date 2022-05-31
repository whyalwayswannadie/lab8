using System.Collections.Generic;
using System.Linq;

namespace EssentialTools.Models
{
    public class LinqValueCalculatorBase
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price);
        }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}