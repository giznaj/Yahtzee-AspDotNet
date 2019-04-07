using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yahtzee.Startup))]
namespace Yahtzee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
