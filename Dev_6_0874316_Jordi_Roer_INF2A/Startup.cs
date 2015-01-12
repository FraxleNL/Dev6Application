using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dev_6_0874316_Jordi_Roer_INF2A.Startup))]
namespace Dev_6_0874316_Jordi_Roer_INF2A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
