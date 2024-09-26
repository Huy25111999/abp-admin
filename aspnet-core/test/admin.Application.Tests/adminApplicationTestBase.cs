using Volo.Abp.Modularity;

namespace admin;

public abstract class adminApplicationTestBase<TStartupModule> : adminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
