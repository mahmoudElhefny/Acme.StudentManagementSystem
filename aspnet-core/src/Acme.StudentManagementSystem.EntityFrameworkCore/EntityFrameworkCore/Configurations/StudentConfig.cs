using Acme.StudentManagementSystem.Students;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.StudentManagementSystem.EntityFrameworkCore.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ConfigureByConvention();
            builder.HasQueryFilter(s => !s.IsDeleted);
            builder.Property(s => s.Name).IsRequired().HasMaxLength(150);
            builder.Property(s => s.Age).IsRequired();

            builder.HasOne(s => s.Grade)
             .WithMany(g => g.Students)
             .HasForeignKey(s => s.GradeId)
             .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
