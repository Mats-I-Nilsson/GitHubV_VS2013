using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GtHub_test.Startup))]
namespace GtHub_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
