using Microsoft.AspNetCore.Builder; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Oqtane.Infrastructure;
using Trailblazor.Module.Lottie.Repository;
using Trailblazor.Module.Lottie.Services;

namespace Trailblazor.Module.Lottie.Startup
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
            services.AddTransient<ILottieService, ServerLottieService>();
            services.AddDbContextFactory<LottieContext>(opt => { }, ServiceLifetime.Transient);
        }
    }
}
