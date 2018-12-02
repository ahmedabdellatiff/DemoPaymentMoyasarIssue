using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoPaymentMoyasarIssue.Startup))]
namespace DemoPaymentMoyasarIssue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
