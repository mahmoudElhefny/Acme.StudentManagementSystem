using Acme.StudentManagementSystem.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.StudentManagementSystem.Grades
{
    public class Grade : FullAuditedAggregateRoot<int>
    {
        public string Name { get; set; }
        // Navigation Property
        public virtual ICollection<Student> Students { get; set; }
    }
}
