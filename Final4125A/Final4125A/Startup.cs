using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Final4125A.Startup))]
namespace Final4125A
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
