using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZigId.Startup))]
namespace ZigId
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
