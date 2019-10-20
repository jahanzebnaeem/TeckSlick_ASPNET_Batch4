using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCController.Startup))]
namespace MVCController
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
