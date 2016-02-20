using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MojavezSystem.Startup))]
namespace MojavezSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
