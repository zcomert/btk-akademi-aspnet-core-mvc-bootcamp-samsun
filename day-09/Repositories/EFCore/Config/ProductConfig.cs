using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id); // PK : Convention
            builder.Property(p => p.ProductName).IsRequired();

            builder.Property(p => p.ImageUrl)
                .HasDefaultValue("/images/products/default.jpg");

            builder.Property(p => p.AtCreated)
                //.HasDefaultValue(DateTime.Now)
                .HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.Description).HasDefaultValue("...");

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Product()
                {
                    Id = 1,
                    ProductName = "HP Z Book",
                    Price = 15_000,
                    ImageUrl = "/images/products/1.jpg",
                    Description = "HP Laptop Touch your Dreams",
                    CategoryId = 1
                },
                new Product(2, "AirPods", 5_000)
                {
                    Description = "Airpods for your ears",
                    ImageUrl = "/images/products/2.jpg",
                    CategoryId = 2
                },
                new Product(3, "Samsun Galaxy Note FE", 7_000)
                {
                    CategoryId = 3
                }
                );
        }
    }
}
