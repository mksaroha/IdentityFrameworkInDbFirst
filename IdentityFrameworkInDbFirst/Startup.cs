using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityFrameworkInDbFirst.Startup))]
namespace IdentityFrameworkInDbFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
