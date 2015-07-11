using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CurrencyExchange.Startup))]
namespace CurrencyExchange
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
