using Acme.CustomerStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.CustomerStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CustomerStoreEntityFrameworkCoreModule),
    typeof(CustomerStoreApplicationContractsModule)
    )]
public class CustomerStoreDbMigratorModule : AbpModule
{

}
