using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGenerator.Startup))]
namespace WebAppGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
