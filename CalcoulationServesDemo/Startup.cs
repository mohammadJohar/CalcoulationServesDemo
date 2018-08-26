using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalcoulationServesDemo.Startup))]
namespace CalcoulationServesDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
