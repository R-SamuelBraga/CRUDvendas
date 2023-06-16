using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploVendas.Startup))]
namespace ExemploVendas
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
