using Acme.StudentManagementSystem.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.StudentManagementSystem.Services
{
    public interface IStudentService : ICrudAppService< //Defines CRUD methods
        StudentDto, //Used to show books
        int, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        StudentCreateUpdateDto> //Used to create/update a book
    {
    }
}
