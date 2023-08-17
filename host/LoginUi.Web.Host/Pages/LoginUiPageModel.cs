using Reevo.LoginUi.Web.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Reevo.LoginUi.Pages;

public abstract class LoginUiPageModel : AbpPageModel
{
    protected LoginUiPageModel()
    {
        LocalizationResourceType = typeof(AbpLoginUiResource);
    }
}
