using Acme.StudentManagementSystem.Dto;
using Acme.StudentManagementSystem.Students;
using AutoMapper;

namespace Acme.StudentManagementSystem;

public class StudentManagementSystemApplicationAutoMapperProfile : Profile
{
    public StudentManagementSystemApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>()
                .ForMember(dest => dest.GradeName, opt => opt.MapFrom(src => src.Grade.Name));
        ;
        CreateMap<Student, StudentCreateUpdateDto>().ReverseMap();

    }
}
