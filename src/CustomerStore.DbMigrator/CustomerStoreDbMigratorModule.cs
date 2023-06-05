using CustomerStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CustomerStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerStoreEntityFrameworkCoreModule),
    typeof(CustomerStoreApplicationContractsModule)
    )]
public class CustomerStoreDbMigratorModule : AbpModule
{

}
