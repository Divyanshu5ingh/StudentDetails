using System;
using System.Collections.Generic;
using System.Text;
using StudentDetails.Localization;
using Volo.Abp.Application.Services;

namespace StudentDetails;

/* Inherit your application services from this class.
 */
public abstract class StudentDetailsAppService : ApplicationService
{
    protected StudentDetailsAppService()
    {
        LocalizationResource = typeof(StudentDetailsResource);
    }
}
