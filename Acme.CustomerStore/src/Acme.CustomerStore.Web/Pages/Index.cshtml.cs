using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Acme.CustomerStore.Web.Pages;

public class IndexModel : CustomerStorePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
