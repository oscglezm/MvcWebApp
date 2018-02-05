using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcWebApp.Startup))]
namespace mvcWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
