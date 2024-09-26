using admin.Localization;
using Volo.Abp.AspNetCore.Components;

namespace admin.Blazor.WebApp;

public abstract class adminComponentBase : AbpComponentBase
{
    protected adminComponentBase()
    {
        LocalizationResource = typeof(adminResource);
    }
}
