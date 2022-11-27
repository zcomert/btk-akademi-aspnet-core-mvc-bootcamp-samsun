using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; } // property default : 0
        public String? ProductName { get; set; } // default : null
        public Decimal Price { get; set; }  // default: 0
        public String? ImageUrl { get; set; }
        public String? Description { get; set; }
        public DateTime? AtCreated { get; set; }

        public Product()
        {
            AtCreated = DateTime.Now;
        }

        public Product(int id, string productName, decimal price) : this()
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }
    }
}
