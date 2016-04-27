using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sklep_Leaware.Startup))]
namespace Sklep_Leaware
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
