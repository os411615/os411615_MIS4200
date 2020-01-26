using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(os411615_MIS4200.Startup))]
namespace os411615_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
