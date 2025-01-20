using Acme.StudentManagementSystem.Dto;
using Acme.StudentManagementSystem.Students;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentManagementSystem.Services
{
    public class StudentService : CrudAppService<
        Student, //The Book entity
        StudentDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        StudentCreateUpdateDto>, //Used to create/update a book
    IStudentService //implement the IBookAppService
    {
        public StudentService(IRepository<Student, int> repository)
        : base(repository)
        {

        }
    }
}
