using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SchoolBus_Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_DataAccess.Configurations
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.Property(d => d.FirstName).HasMaxLength(50);
            builder.Property(d => d.LastName).HasMaxLength(50);
            builder.Property(d => d.Phone).HasMaxLength(20);
            builder.Property(d => d.Username).HasMaxLength(50);
            builder.Property(d => d.Password).HasMaxLength(100);
            builder.Property(d => d.HomeAddress).HasMaxLength(100);
            builder.Property(d => d.Licence).HasMaxLength(50);
        }
    }
}
