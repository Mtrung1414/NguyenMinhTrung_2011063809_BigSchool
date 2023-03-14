using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenMinhTrung_2011063809.Startup))]
namespace NguyenMinhTrung_2011063809
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
