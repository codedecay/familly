using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyProgramsHawaii.Startup))]
namespace FamilyProgramsHawaii
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
