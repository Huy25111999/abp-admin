using Volo.Abp.Modularity;

namespace admin;

[DependsOn(
    typeof(adminDomainModule),
    typeof(adminTestBaseModule)
)]
public class adminDomainTestModule : AbpModule
{

}
