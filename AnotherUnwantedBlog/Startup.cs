using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnotherUnwantedBlog.Startup))]
namespace AnotherUnwantedBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
