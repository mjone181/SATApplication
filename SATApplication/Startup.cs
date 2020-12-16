using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SATApplication.Startup))]
namespace SATApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
