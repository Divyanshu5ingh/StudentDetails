using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace StudentDetails;

public class StudentDetailsWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<StudentDetailsWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
