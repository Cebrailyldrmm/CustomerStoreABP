using CustomerStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CustomerStore.Web.Pages;

public abstract class CustomerStorePageModel : AbpPageModel
{
    protected CustomerStorePageModel()
    {
        LocalizationResourceType = typeof(CustomerStoreResource);
    }
}
