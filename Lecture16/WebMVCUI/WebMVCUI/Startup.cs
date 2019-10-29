using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMVCUI.Startup))]
namespace WebMVCUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
