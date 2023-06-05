﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.CustomerStore.Web;

[Dependency(ReplaceServices = true)]
public class CustomerStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CustomerStore";
}
