using System.Threading.Tasks;

namespace Acme.CustomerStore.Data;

public interface ICustomerStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
