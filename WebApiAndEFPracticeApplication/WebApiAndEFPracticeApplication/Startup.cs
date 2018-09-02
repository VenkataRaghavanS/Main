using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApiAndEFPracticeApplication.Startup))]

namespace WebApiAndEFPracticeApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
