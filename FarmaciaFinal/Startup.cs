using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FarmaciaFinal.Startup))]
namespace FarmaciaFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
