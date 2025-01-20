using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.StudentManagementSystem.Dto
{
    public class StudentCreateUpdateDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GradeId { get; set; }
    }
}
