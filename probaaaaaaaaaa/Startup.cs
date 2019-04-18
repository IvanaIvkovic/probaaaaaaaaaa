using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(probaaaaaaaaaa.Startup))]
namespace probaaaaaaaaaa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
