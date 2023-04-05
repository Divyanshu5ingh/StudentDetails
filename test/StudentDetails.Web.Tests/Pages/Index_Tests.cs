using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace StudentDetails.Pages;

public class Index_Tests : StudentDetailsWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
