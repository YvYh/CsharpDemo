using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstDemo.Startup))]
namespace FirstDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
