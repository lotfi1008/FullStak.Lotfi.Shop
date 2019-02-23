using FullStak.Lotfi.Shop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStak.Lotfi.Shop.DalEF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasIndex(c => c.UserName).IsUnique();
            builder.Property(c => c.UserName).IsRequired();
            builder.Property(c => c.Email).IsRequired();
        }
    }


}
