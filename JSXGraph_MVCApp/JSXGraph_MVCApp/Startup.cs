using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSXGraph_MVCApp.Startup))]
namespace JSXGraph_MVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
