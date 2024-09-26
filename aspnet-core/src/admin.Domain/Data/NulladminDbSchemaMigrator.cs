using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace admin.Data;

/* This is used if database provider does't define
 * IadminDbSchemaMigrator implementation.
 */
public class NulladminDbSchemaMigrator : IadminDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
