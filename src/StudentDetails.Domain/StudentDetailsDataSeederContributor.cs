using System;
using System.Threading.Tasks;
using StudentDetails.Students;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace StudentDetails;

public class StudentDetailsDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Student, Guid> _studentRepository;

    public StudentDetailsDataSeederContributor(IRepository<Student, Guid> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _studentRepository.GetCountAsync() <= 0)
        {
            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Divyanshu",
                    Roll = 17,
                    Email = "divu14@gmail.com",
                    Phone = 8877665544,
                    Address = "Vadodara"
                },
                autoSave: true
            );

            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Haresh",
                    Roll = 20,
                    Email = "hari65@gmail.com",
                    Phone = 9988776655,
                    Address = "Vadodara"
                },
                autoSave: true
            );
        }
    }
}
