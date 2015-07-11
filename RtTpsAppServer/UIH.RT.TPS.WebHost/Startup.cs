using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using UIH.RT.TPS.Api;

[assembly: OwinStartup(typeof(UIH.RT.TPS.WebHost.Startup))]

namespace UIH.RT.TPS.WebHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            WebApiConfig.Initialize(app);
        }
    }
}
