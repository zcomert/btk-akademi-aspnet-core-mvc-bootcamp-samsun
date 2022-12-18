using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract record ProductManipulationDto
    {
        [Required(ErrorMessage = "Product Name is required.")]
        public String? ProductName { get; init; } // default : null

        [Required(ErrorMessage = "Price is required.")]
        public Decimal Price { get; init; }  // default: 0
        public String? ImageUrl { get; init; }
        public String? Description { get; init; }
        public int? CategoryId { get; init; }
    }
}
