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
    public class RideConfiguration : IEntityTypeConfiguration<Ride>
    {
        public void Configure(EntityTypeBuilder<Ride> builder)
        {
            builder.Property(r => r.FullName).HasMaxLength(100);
            builder.HasMany(r => r.Students)
                   .WithOne(s => s.Ride)
                   .HasForeignKey(s => s.RideId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(r => r.Bus)
                   .WithMany()
                   .HasForeignKey(r => r.BusId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
