using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalAppAcropoli.Startup))]
namespace FinalAppAcropoli
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
