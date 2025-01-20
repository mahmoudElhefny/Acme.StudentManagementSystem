using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.StudentManagementSystem.Dto
{
    public class StudentDto : AuditedEntityDto<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // public int GradeId { get; set; }
        public string GradeName { get; set; } // Add this property

    }
}
