using System.Collections.Generic;

namespace EssentialTools.Models
{
    internal interface IValueCalculator1
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}