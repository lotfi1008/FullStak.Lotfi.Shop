using FullStak.Lotfi.Shop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullStak.Lotfi.Shop.DalEF.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.CustomerId).IsRequired();
            builder.Property(o => o.OrderDate).IsRequired();
        }
    }


}
