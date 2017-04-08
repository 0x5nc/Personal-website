using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Personal_Website.Startup))]
namespace Personal_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
