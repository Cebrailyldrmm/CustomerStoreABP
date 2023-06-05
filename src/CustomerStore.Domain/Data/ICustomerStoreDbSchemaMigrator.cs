using System.Threading.Tasks;

namespace CustomerStore.Data;

public interface ICustomerStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
