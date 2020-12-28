using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace ApiTester
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> DeleteAsJsonAsync(this HttpClient httpClient, string requestUri, HttpContent data)
            => httpClient.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUri)
            {
                Content = data
            });
    }
}
