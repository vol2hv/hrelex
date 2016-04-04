using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hrelex.Startup))]
namespace hrelex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
