using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneDollar.Startup))]
namespace OneDollar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
