using ECommerceMaster.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceMaster.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SupplierMap: IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        { 
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CompanyName).IsRequired();
            builder.Property(c => c.CompanyName).HasMaxLength(70);
            builder.Property(c => c.ContactName).IsRequired();
            builder.Property(c => c.ContactName).HasMaxLength(70);
            builder.Property(c => c.ContactTitle).IsRequired();
            builder.Property(c => c.ContactTitle).HasMaxLength(70);
            builder.Property(c => c.Address).HasMaxLength(500);
            builder.Property(c => c.City).IsRequired();
            builder.Property(c => c.City).HasMaxLength(70);
            builder.Property(c => c.Region).IsRequired();
            builder.Property(c => c.Region).HasMaxLength(70);
            builder.Property(c => c.PostalCode).HasMaxLength(70);
            builder.Property(c => c.PostalCode).IsRequired();
            builder.Property(c => c.Country).HasMaxLength(70);
            builder.Property(c => c.Country).IsRequired();
            builder.Property(c => c.Phone).HasMaxLength(70);
            builder.Property(c => c.Phone).IsRequired();
            builder.Property(c => c.Fax).HasMaxLength(70);
            builder.Property(c => c.Fax).IsRequired();
            builder.Property(c => c.HomePage).HasMaxLength(70);
            builder.Property(c => c.HomePage).IsRequired();
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Suppliers");
            
        }
    }
}
