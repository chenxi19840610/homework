using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UIH.RT.TPS.Client
{
    public abstract class HttpApiClient
    {
        protected HttpClient _httpClient;

        public HttpApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
