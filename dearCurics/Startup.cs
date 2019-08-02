using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dearCurics.Startup))]
namespace dearCurics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
