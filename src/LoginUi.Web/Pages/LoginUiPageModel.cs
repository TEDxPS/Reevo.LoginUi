using Reevo.LoginUi.Web.Localization;
using Reevo.LoginUi.Web.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Reevo.LoginUi.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LoginUiPageModel : AbpPageModel
{
    protected LoginUiPageModel()
    {
        LocalizationResourceType = typeof(AbpLoginUiResource);
        ObjectMapperContext = typeof(AbpLoginUiWebModule);
    }
}
