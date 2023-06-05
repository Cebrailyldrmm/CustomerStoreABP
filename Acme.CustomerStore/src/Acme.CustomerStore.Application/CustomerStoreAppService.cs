using System;
using System.Collections.Generic;
using System.Text;
using Acme.CustomerStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.CustomerStore;

/* Inherit your application services from this class.
 */
public abstract class CustomerStoreAppService : ApplicationService
{
    protected CustomerStoreAppService()
    {
        LocalizationResource = typeof(CustomerStoreResource);
    }
}
