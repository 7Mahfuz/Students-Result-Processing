using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Student_Result_Processing_Web.Startup))]
namespace Student_Result_Processing_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
