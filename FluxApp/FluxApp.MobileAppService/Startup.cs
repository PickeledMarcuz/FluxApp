using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FluxApp.MobileAppService.Startup))]

namespace FluxApp.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}