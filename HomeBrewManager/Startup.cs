using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeBrewManager.Startup))]
namespace HomeBrewManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
