using Volo.Abp.Modularity;

namespace StudentDetails;

[DependsOn(
    typeof(StudentDetailsApplicationModule),
    typeof(StudentDetailsDomainTestModule)
    )]
public class StudentDetailsApplicationTestModule : AbpModule
{

}
