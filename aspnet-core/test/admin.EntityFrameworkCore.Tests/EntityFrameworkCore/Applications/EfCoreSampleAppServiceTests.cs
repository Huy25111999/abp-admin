using admin.Samples;
using Xunit;

namespace admin.EntityFrameworkCore.Applications;

[Collection(adminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<adminEntityFrameworkCoreTestModule>
{

}
