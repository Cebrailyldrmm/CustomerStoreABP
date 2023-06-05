using Volo.Abp.Modularity;

namespace CustomerStore;

[DependsOn(
    typeof(CustomerStoreApplicationModule),
    typeof(CustomerStoreDomainTestModule)
    )]
public class CustomerStoreApplicationTestModule : AbpModule
{

}
