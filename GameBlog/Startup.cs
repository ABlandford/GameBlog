using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameBlog.Startup))]
namespace GameBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
