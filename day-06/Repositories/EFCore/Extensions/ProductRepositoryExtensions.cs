using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Extensions
{
    public static class ProductRepositoryExtensions
    {
        public static IQueryable<Product>
            FilterProducts(this IQueryable<Product> products,
            uint minPrice,
            uint maxPrice)
        {
            return products.Where(prd =>
            prd.Price <= maxPrice && prd.Price >= minPrice);
        }

    }
}
