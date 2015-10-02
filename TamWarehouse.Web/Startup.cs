using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TamWarehouse.Web.Startup))]
namespace TamWarehouse.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
