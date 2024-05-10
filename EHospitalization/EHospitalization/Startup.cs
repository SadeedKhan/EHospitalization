using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EHospitalization.Startup))]
namespace EHospitalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
