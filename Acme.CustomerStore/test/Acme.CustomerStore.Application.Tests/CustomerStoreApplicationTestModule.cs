using Volo.Abp.Modularity;

namespace Acme.CustomerStore;

[DependsOn(
    typeof(CustomerStoreApplicationModule),
    typeof(CustomerStoreDomainTestModule)
    )]
public class CustomerStoreApplicationTestModule : AbpModule
{

}
