using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TI.TRANSPARENCIA.UI.Startup))]
namespace TI.TRANSPARENCIA.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
