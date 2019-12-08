using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCIdentityIntro.Startup))]
namespace MVCIdentityIntro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
