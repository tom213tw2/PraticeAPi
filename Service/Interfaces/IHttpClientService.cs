using System.Net.Http;
using System.Threading.Tasks;

namespace PraticeAPi.Service.Interfaces
{
    public interface IHttpClientService
    {
        Task<HttpResponseMessage> GetAsync(string url);
    }
}