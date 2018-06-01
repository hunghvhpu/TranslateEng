using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranslateEng.Startup))]
namespace TranslateEng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
