using System.Threading.Tasks;

namespace StudentDetails.Data;

public interface IStudentDetailsDbSchemaMigrator
{
    Task MigrateAsync();
}
