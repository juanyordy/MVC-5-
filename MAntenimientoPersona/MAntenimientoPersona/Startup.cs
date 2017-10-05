using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MAntenimientoPersona.Startup))]
namespace MAntenimientoPersona
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
