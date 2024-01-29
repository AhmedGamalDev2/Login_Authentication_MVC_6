using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login_Auth_MVC_6.Startup))]
namespace Login_Auth_MVC_6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
