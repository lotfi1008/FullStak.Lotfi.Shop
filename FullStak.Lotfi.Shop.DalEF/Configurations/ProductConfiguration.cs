using FullStak.Lotfi.Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStak.Lotfi.Shop.DalEF.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p=>p.Price).IsRequired();
            builder.Property(p=>p.Title).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.Description).IsRequired().HasMaxLength(350);
        }
    }


}
