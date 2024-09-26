using Volo.Abp.Modularity;

namespace admin;

[DependsOn(
    typeof(adminApplicationModule),
    typeof(adminDomainTestModule)
)]
public class adminApplicationTestModule : AbpModule
{

}
