using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dojo.Banco.Web.Startup))]
namespace Dojo.Banco.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
