using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TecnoDona.Startup))]
namespace TecnoDona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
