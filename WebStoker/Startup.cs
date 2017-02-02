using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStoker.Startup))]
namespace WebStoker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
