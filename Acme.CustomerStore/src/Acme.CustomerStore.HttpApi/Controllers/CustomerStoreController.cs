using Acme.CustomerStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.CustomerStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CustomerStoreController : AbpControllerBase
{
    protected CustomerStoreController()
    {
        LocalizationResource = typeof(CustomerStoreResource);
    }
}
