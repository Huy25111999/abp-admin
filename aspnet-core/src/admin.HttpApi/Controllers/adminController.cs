using admin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class adminController : AbpControllerBase
{
    protected adminController()
    {
        LocalizationResource = typeof(adminResource);
    }
}
