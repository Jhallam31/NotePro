using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotePro.WebMVC.Startup))]
namespace NotePro.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
