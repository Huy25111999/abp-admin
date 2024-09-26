using Microsoft.Extensions.Localization;
using admin.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace admin;

[Dependency(ReplaceServices = true)]
public class adminBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<adminResource> _localizer;

    public adminBrandingProvider(IStringLocalizer<adminResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
