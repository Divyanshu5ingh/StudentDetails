using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace StudentDetails.Web;

[Dependency(ReplaceServices = true)]
public class StudentDetailsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentDetails";
}
