using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommerceMaster.Entities.Concrete;

namespace ECommerceMaster.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100);
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Description).IsRequired();
            builder.Property(a => a.Description).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.ISBN).IsRequired();
            builder.Property(a => a.ImageUrl).IsRequired();
            builder.Property(a => a.ImageUrl).HasMaxLength(250);
        
            builder.Property(a => a.ListPrice).IsRequired();
            builder.Property(a => a.Price).IsRequired();
            builder.Property(a => a.Price50).IsRequired();
            builder.Property(a => a.Price100).IsRequired();

            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Products).HasForeignKey(a => a.CategoryId);
            //builder.HasOne<User>(a => a.User).WithMany(u => u.Products).HasForeignKey(a => a.UserId);
            builder.ToTable("Products");

            builder.HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl="cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice=100,
                    Price=90,
                    Price50=60,
                    Price100=50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 4,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 5,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 6,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 7,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id =8,
                    CategoryId = 8,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 9,
                    Title = "C# 9.0 ve .NET 5 Yenilikleri",
                    Description = "Deneme Açıklama",
                    ISBN = "45645sdfhsh",
                    ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                    ListPrice = 100,
                    Price = 90,
                    Price50 = 60,
                    Price100 = 50,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 9.0 ve .NET 5 Yenilikleri",
                },
                 new Product
                 {
                     Id = 10,
                     CategoryId = 10,
                     Title = "C# 9.0 ve .NET 5 Yenilikleri",
                     Description = "Deneme Açıklama",
                     ISBN = "45645sdfhsh",
                     ImageUrl = "cvbzxgasdfg sdfgsdfg sdfg sdfg sdfg ",
                     ListPrice = 100,
                     Price = 90,
                     Price50 = 60,
                     Price100 = 50,
                     IsActive = true,
                     IsDeleted = false,
                     CreatedByName = "InitialCreate",
                     CreatedDate = DateTime.Now,
                     ModifiedByName = "InitialCreate",
                     ModifiedDate = DateTime.Now,
                     Note = "C# 9.0 ve .NET 5 Yenilikleri",
                 }
            ) ;
        }
    }
}
