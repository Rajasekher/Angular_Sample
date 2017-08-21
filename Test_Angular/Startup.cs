using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assesment_kiran.Startup))]
namespace Assesment_kiran
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
