using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentDetails.Data;

/* This is used if database provider does't define
 * IStudentDetailsDbSchemaMigrator implementation.
 */
public class NullStudentDetailsDbSchemaMigrator : IStudentDetailsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
