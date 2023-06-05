using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.CustomerStore;

[Dependency(ReplaceServices = true)]
public class CustomerStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomerStore";
}
