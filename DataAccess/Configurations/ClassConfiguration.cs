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
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.Property(c => c.Name).HasMaxLength(100);
            builder.HasMany(c => c.Students)
                   .WithOne(s => s.Class)
                   .HasForeignKey(s => s.ClassId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
