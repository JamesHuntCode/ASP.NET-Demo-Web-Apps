using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreateStaffMemberDemo.Startup))]
namespace CreateStaffMemberDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
