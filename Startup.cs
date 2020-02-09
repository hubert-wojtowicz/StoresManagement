using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoresManagement.Startup))]
namespace StoresManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
