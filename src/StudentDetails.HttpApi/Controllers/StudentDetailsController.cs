using StudentDetails.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentDetails.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentDetailsController : AbpControllerBase
{
    protected StudentDetailsController()
    {
        LocalizationResource = typeof(StudentDetailsResource);
    }
}
