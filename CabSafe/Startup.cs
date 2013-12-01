using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CabSafe.Startup))]
namespace CabSafe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
