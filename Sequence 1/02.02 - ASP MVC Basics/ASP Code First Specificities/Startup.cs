using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Code_First_Specificities.Startup))]
namespace ASP_Code_First_Specificities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
