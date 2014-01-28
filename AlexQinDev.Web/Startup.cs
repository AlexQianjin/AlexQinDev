using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlexQinDev.Web.Startup))]
namespace AlexQinDev.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
