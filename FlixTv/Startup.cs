using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlixTv.Startup))]
namespace FlixTv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
