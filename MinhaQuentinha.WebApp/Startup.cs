using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MinhaQuentinha.WebApp.Startup))]
namespace MinhaQuentinha.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
