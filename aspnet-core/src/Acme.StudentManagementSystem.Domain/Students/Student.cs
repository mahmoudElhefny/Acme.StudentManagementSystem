using Acme.StudentManagementSystem.Grades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.StudentManagementSystem.Students
{
    public class Student : FullAuditedAggregateRoot<int>
    {
        [Required]
        public string Name { get; set; }
        [Range(5, 18)]
        public int Age { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}
