using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTecnoDona.Startup))]
namespace WebTecnoDona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
