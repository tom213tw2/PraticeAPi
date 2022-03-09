using System.Net.Http;
using System.Threading.Tasks;
using PraticeAPi.Service.Interfaces;

namespace PraticeAPi.Service
{
    public class HttpClientService:IHttpClientService
    {
        private readonly HttpClient _httpClient;

        public HttpClientService(HttpClient httpClient)
        {
            this._httpClient=httpClient;
        }
        /// <summary>
        /// 抓取網頁內容
        /// </summary>
        /// <param name="url">網址</param>
        /// <returns></returns>
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }

    }
}