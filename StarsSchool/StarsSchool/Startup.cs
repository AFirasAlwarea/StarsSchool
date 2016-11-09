using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StarsSchool.Startup))]
namespace StarsSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
