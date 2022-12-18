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

        public static IQueryable<Product> Search(this IQueryable<Product> products,
            string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return products;

            return products.Where(p => p.ProductName.ToLower()
            .Contains(searchTerm.ToLower()));
        }

    }
}
