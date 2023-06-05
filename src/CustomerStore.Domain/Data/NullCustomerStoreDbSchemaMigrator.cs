using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CustomerStore.Data;

/* This is used if database provider does't define
 * ICustomerStoreDbSchemaMigrator implementation.
 */
public class NullCustomerStoreDbSchemaMigrator : ICustomerStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
