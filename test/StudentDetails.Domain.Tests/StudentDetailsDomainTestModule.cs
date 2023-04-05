using StudentDetails.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace StudentDetails;

[DependsOn(
    typeof(StudentDetailsEntityFrameworkCoreTestModule)
    )]
public class StudentDetailsDomainTestModule : AbpModule
{

}
