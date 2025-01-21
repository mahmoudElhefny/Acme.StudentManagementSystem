using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.StudentManagementSystem.Dto
{
    public class StudentDtoValidator : AbstractValidator<StudentCreateUpdateDto>
    {
        public StudentDtoValidator()
        {
            RuleFor(s => s.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(50).WithMessage("Name must not exceed 150 characters."); //As A dummy Validation

            RuleFor(s => s.Age)
            .NotEmpty().WithMessage("Age is required.")
            .InclusiveBetween(5, 18).WithMessage("Age must be between 12 and 18.");

            RuleFor(s => s.GradeId)
            .NotEmpty().WithMessage("Grade is required.");
        }
    }
}
