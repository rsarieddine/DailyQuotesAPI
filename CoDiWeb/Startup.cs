using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoDiWeb.Startup))]
namespace CoDiWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
