using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMy.Startup))]
namespace WebMy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
