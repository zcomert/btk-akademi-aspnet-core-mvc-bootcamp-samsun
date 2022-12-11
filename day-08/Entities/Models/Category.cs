using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage ="CategoryName is required.")]
        [MinLength(5, ErrorMessage = "CategoryName must consist of at least 5 characters.")]
        public String? CategoryName { get; set; }

        // Collection navigation property
        public ICollection<Product>? Products { get; set; }
    }
}
