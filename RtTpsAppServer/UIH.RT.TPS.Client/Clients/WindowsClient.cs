using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UIH.RT.TPS.ApiModel.Dtos;

namespace UIH.RT.TPS.Client.Clients
{
    public class WindowsClient : HttpApiClient, IWindowsClient
    {
        public WindowsClient(HttpClient httpClient) : base(httpClient) { }

        public void CreateWindow(WindowUnit windowUnit)
        {
        }
    }
}
