using admin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace admin.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(adminEntityFrameworkCoreModule),
    typeof(adminApplicationContractsModule)
    )]
public class adminDbMigratorModule : AbpModule
{
}
