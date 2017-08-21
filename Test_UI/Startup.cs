using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_UI.Startup))]
namespace Test_UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
