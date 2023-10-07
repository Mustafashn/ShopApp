
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopapp.entity;

namespace shopapp.data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(m => m.ProductId);
            builder.Property(m => m.Name).IsRequired().HasMaxLength(50);
            builder.HasData(
            new Product() { ProductId = 1, Name = "Iphone 5", Price = 3000, ImageUrl = "1.jpg", Description = "iyi telefon", isApproved = true, Url = "iphone-5" },
            new Product() { ProductId = 2, Name = "Iphone 4", Price = 2000, ImageUrl = "2.jpg", Description = "iyi telefon", isApproved = true, Url = "iphone-4" },
            new Product() { ProductId = 3, Name = "Samsung S7", Price = 4000, ImageUrl = "3.jpg", Description = "iyi telefon", isApproved = true, Url = "samsung-s7" },
            new Product() { ProductId = 4, Name = "Samsung S8", Price = 5000, ImageUrl = "4.jpg", Description = "iyi telefon", isApproved = true, Url = "samsung-s8" },
            new Product() { ProductId = 5, Name = "Iphone 6", Price = 5000, ImageUrl = "5.jpg", Description = "iyi telefon", isApproved = false, Url = "iphone-6" },
            new Product() { ProductId = 6, Name = "Macbook Air", Price = 9000, ImageUrl = "8.jpg", Description = "iyi bilgisayar", isApproved = true, Url = "macbook-air" },
            new Product() { ProductId = 7, Name = "Arçelik Buzdolabı", Price = 4500, ImageUrl = "9.jpg", Description = "süper buzdolabı", isApproved = true, Url = "arcelik-buzdolabı" }
            );
        }
    }
}