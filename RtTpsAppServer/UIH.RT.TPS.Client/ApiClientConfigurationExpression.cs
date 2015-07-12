using System;
using System.Configuration;
using System.Text;

namespace UIH.RT.TPS.Client
{

    public class ApiClientConfigurationExpression
    {

        private readonly ApiClientContext _apiClientContext;

        internal ApiClientConfigurationExpression(ApiClientContext apiClientContext)
        {

            if (apiClientContext == null)
            {

                throw new ArgumentNullException("apiClientContext");
            }

            _apiClientContext = apiClientContext;
        }

        public ApiClientConfigurationExpression ConnectTo(string baseUri)
        {

            if (string.IsNullOrEmpty(baseUri))
            {

                throw new ArgumentNullException("baseUri");
            }

            _apiClientContext.BaseUri = new Uri(baseUri);

            return this;
        }
    }
}