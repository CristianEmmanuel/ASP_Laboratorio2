using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cristian.Laboratorio2.Startup))]
namespace Cristian.Laboratorio2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
