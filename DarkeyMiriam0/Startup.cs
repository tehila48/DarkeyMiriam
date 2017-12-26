using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DarkeyMiriam0.Startup))]
namespace DarkeyMiriam0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
