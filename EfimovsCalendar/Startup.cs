using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EfimovsCalendar.Startup))]
namespace EfimovsCalendar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
