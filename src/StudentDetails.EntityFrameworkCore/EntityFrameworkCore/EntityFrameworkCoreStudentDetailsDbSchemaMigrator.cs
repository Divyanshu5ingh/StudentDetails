using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentDetails.Data;
using Volo.Abp.DependencyInjection;

namespace StudentDetails.EntityFrameworkCore;

public class EntityFrameworkCoreStudentDetailsDbSchemaMigrator
    : IStudentDetailsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentDetailsDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentDetailsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentDetailsDbContext>()
            .Database
            .MigrateAsync();
    }
}
