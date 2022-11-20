namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; } // property default : 0
        public String ProductName { get; set; } // default : null
        public Decimal Price { get; set; }  // default: 0

        public Product()
        {

        }

        public Product(int id, string productName, decimal price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }
    }
}
