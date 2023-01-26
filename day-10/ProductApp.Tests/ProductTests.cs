using Entities.Models;
using Moq;
using ProductApp.Areas.Admin.Controllers;
using Repositories.Contracts;

namespace ProductApp.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            mock.Setup(m => m.Product).Returns(
                new List<Product>()
                {
                    new Product {Id=1, ProductName = "P1"},
                    new Product {Id=2, ProductName = "P2"},
                });
        }
    }
}