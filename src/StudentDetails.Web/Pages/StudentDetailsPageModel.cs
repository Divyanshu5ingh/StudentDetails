using StudentDetails.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StudentDetails.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentDetailsPageModel : AbpPageModel
{
    protected StudentDetailsPageModel()
    {
        LocalizationResourceType = typeof(StudentDetailsResource);
    }
}
