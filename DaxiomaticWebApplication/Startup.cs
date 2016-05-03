using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DaxiomaticWebApplication.Startup))]
namespace DaxiomaticWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
