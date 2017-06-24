using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DWSHTA.WebApi.Startup))]

namespace DWSHTA.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}