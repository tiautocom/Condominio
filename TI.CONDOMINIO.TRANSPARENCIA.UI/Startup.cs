using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TI.CONDOMINIO.TRANSPARENCIA.UI.Startup))]
namespace TI.CONDOMINIO.TRANSPARENCIA.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
