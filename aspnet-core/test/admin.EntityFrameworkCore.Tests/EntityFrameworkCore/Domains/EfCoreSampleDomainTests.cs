using admin.Samples;
using Xunit;

namespace admin.EntityFrameworkCore.Domains;

[Collection(adminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<adminEntityFrameworkCoreTestModule>
{

}
