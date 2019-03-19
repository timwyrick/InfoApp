using System;
using System.Net.Http;
using System.Threading.Tasks;
using InfoApp.Application;
using Microsoft.Extensions.Logging;

namespace InfoApp.Infrastructure
{
    public class AppHttpClient
    {
        private HttpClient _client;
        private readonly ILogger<AppHttpClient> _logger;

        public AppHttpClient(
            ILogger<AppHttpClient> logger
            )
        {
            _client = new HttpClient();
            _logger = logger;
        }

        public async Task<HttpResult<T>> GetAsync<T>(string url)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<HttpResult<T>> PostAsync<T>(string url, HttpContent content)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<HttpResult<T>> PutAsync<T>(string url, HttpContent content)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
