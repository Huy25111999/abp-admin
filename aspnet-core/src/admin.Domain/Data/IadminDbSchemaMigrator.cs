using System.Threading.Tasks;

namespace admin.Data;

public interface IadminDbSchemaMigrator
{
    Task MigrateAsync();
}
