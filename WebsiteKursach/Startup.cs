using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteKursach.Startup))]
namespace WebsiteKursach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
