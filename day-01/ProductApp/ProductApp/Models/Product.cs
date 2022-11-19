namespace ProductApp.Models
{
    public class Product
    {
        public int Id { get; set; }  // Property : 0
        public String ProductName { get; set; }  // null 
        public Decimal Price { get; set; } // 0 

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
