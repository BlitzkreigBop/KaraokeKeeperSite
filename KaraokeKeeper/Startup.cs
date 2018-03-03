using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KaraokeKeeper.Startup))]
namespace KaraokeKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
