using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Product
    {
        public int Id { get; set; } // property default : 0
        
        [Required(ErrorMessage ="Product Name is required.")]
        public String? ProductName { get; set; } // default : null
        
        [Required(ErrorMessage = "Price is required.")]
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
