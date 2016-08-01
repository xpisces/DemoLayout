using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoLayout.Startup))]
namespace DemoLayout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
