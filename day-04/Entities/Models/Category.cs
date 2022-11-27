using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        [Required(ErrorMessage ="CategoryName is required.")]
        public String? CategoryName { get; set; }
    }
}
