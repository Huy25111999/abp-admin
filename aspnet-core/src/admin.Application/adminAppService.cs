using System;
using System.Collections.Generic;
using System.Text;
using admin.Localization;
using Volo.Abp.Application.Services;

namespace admin;

/* Inherit your application services from this class.
 */
public abstract class adminAppService : ApplicationService
{
    protected adminAppService()
    {
        LocalizationResource = typeof(adminResource);
    }
}
