using Acme.StudentManagementSystem.Grades;
using Acme.StudentManagementSystem.Students;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.StudentManagementSystem.EntityFrameworkCore.Configurations
{
    public class GradeConfig : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasQueryFilter(g => !g.IsDeleted);
            builder.Property(g => g.Name).IsRequired().HasMaxLength(100);
            // Seed data for predefined grades for test purposes otherwise we end user can add grades
            //builder.HasData(
            //    new {Id=-1,Name = "Grade 1" ,ConcurrencyStamp = Guid.NewGuid().ToString()},
            //    new {Id=-1,Name = "Grade 2" ,ConcurrencyStamp = Guid.NewGuid().ToString()},
            //    new {Id=-1,Name = "Grade 3" , ConcurrencyStamp = Guid.NewGuid().ToString() }
            //);
        }
    }
}
