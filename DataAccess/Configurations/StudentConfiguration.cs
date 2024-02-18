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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.FirstName).HasMaxLength(50);
            builder.Property(s => s.LastName).HasMaxLength(50);
            builder.Property(s => s.HomeAddress).HasMaxLength(100);
            builder.Property(s => s.OtherAddress).HasMaxLength(100);
            builder.HasOne(s => s.Parent)
                   .WithMany(p => p.Students)
                   .HasForeignKey(s => s.ParentId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Class)
                   .WithMany(c => c.Students)
                   .HasForeignKey(s => s.ClassId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Ride)
                   .WithMany(r => r.Students)
                   .HasForeignKey(s => s.RideId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
