using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryManagement.Startup))]
namespace LibraryManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
