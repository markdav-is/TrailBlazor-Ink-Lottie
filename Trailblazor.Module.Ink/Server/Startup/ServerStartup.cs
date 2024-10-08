using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Oqtane.Infrastructure;
using Trailblazor.Module.Ink.Repository;
using Trailblazor.Module.Ink.Services;

namespace Trailblazor.Module.Ink.Startup
{
    public class ServerStartup : IServerStartup
    {
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // not implemented
        }

        public void ConfigureMvc(IMvcBuilder mvcBuilder)
        {
            // not implemented
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IInkService, ServerInkService>();
            services.AddDbContextFactory<InkContext>(opt => { }, ServiceLifetime.Transient);
        }
    }
}
