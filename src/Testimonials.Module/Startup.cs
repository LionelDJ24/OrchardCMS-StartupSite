using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace Testimonials.Module
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public override void Configure(IApplicationBuilder app, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapControllerRoute(
                name: "Testimonials.Submit",
                pattern: "Testimonial/Submit",
                defaults: new { controller = "Testimonial", action = "Submit" }
            );
        }
    }
}
