using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPages.Startup))]
namespace MyPages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
