using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIH.RT.TPS.Client.Clients;

namespace UIH.RT.TPS.Client
{
    public static class ApiClientContextExtensions
    {
        public static IWindowsClient GetWindowsClient(this ApiClientContext apiClientContext)
        {

            return apiClientContext.GetClient<IWindowsClient>(() => new WindowsClient(apiClientContext.HttpClient));
        }
    }
}
