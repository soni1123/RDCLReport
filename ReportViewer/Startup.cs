using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportViewer.Startup))]
namespace ReportViewer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
