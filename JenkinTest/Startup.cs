using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinTest.Startup))]
namespace JenkinTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
