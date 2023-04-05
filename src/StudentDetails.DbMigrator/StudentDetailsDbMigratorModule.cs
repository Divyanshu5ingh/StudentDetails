using StudentDetails.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StudentDetails.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentDetailsEntityFrameworkCoreModule),
    typeof(StudentDetailsApplicationContractsModule)
    )]
public class StudentDetailsDbMigratorModule : AbpModule
{

}
