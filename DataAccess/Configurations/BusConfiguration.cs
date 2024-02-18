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
    public class BusConfiguration : IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(100);
            builder.Property(b => b.Number).HasMaxLength(20);
            builder.HasOne(b => b.Driver)
                   .WithOne(d => d.Bus)
                   .HasForeignKey<Driver>(d => d.BusId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
