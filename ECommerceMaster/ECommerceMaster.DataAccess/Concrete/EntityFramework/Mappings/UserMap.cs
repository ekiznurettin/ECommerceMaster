using ECommerceMaster.Core.Entities.Concrete;
using ECommerceMaster.Core.Utilities.Security.Hashing;
using ECommerceMaster.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ECommerceMaster.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap:IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.FirstName).IsRequired();
            builder.Property(a => a.FirstName).HasMaxLength(50);
            builder.Property(a => a.LastName).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(50);
            builder.Property(a => a.Email).IsRequired();
            builder.Property(a => a.Email).HasMaxLength(250);
            builder.Property(a => a.PhoneNumber).HasMaxLength(10);
            builder.Property(a => a.PasswordHash).IsRequired();
            builder.Property(a => a.PasswordHash).HasMaxLength(500);

            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);
            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);
            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.ModifiedDate).IsRequired();
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.IsDeleted).IsRequired();
            builder.Property(a => a.Note).HasMaxLength(500);
            builder.ToTable("Users");

            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("1", out passwordHash, out passwordSalt);
            builder.HasData(new Users { 
                Id=1,
                FirstName="Nurettin",
                LastName = "Ekiz",
                Email="ekiznurettin@gmail.com",
                PasswordHash=passwordHash,
                PasswordSalt=passwordSalt,
                CreatedByName ="nurettin",
                CreatedDate=DateTime.Now,
                IsActive=true,
                IsDeleted=true,
                ModifiedByName="nurettin",
                ModifiedDate=DateTime.Now,
                Note="Deneme Not Alanı"
            }, new Users
            {
                Id = 2,
                FirstName = "Veda",
                LastName = "Ekiz",
                Email = "vedanur@gmail.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CreatedByName = "vedanur",
                CreatedDate = DateTime.Now,
                IsActive = true,
                IsDeleted = true,
                ModifiedByName = "vedanur",
                ModifiedDate = DateTime.Now,
                Note = "Deneme Not Alanı"
            });
        }
    }
}
