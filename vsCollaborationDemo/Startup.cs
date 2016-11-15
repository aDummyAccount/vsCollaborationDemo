using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vsCollaborationDemo.Startup))]
namespace vsCollaborationDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
