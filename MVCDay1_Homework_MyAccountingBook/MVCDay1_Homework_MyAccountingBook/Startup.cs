using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDay1_Homework_MyAccountingBook.Startup))]
namespace MVCDay1_Homework_MyAccountingBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
