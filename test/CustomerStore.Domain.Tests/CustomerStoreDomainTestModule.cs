using CustomerStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CustomerStore;

[DependsOn(
    typeof(CustomerStoreEntityFrameworkCoreTestModule)
    )]
public class CustomerStoreDomainTestModule : AbpModule
{

}
