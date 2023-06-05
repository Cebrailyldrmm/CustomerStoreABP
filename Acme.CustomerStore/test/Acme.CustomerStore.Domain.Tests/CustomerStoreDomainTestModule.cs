using Acme.CustomerStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.CustomerStore;

[DependsOn(
    typeof(CustomerStoreEntityFrameworkCoreTestModule)
    )]
public class CustomerStoreDomainTestModule : AbpModule
{

}
