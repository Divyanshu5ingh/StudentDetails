using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StudentDetails.Students;

public class StudentAppService :
    CrudAppService<
        Student, 
        StudentDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateStudentDto>,
    IStudentAppService 
{
    public StudentAppService(IRepository<Student, Guid> repository)
        : base(repository)
    {

    }
}
