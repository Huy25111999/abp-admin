using Volo.Abp.Modularity;

namespace admin;

/* Inherit from this class for your domain layer tests. */
public abstract class adminDomainTestBase<TStartupModule> : adminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
