using Reevo.LoginUi.Web.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Reevo.LoginUi.Blazor.Server.Host;

public abstract class LoginUiComponentBase : AbpComponentBase
{
    protected LoginUiComponentBase()
    {
        LocalizationResource = typeof(AbpLoginUiResource);
    }
}
