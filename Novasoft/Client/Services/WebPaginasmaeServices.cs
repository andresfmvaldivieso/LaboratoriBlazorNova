using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class WebPaginasmaeServices: IWebPaginasmaeServices
    {
        private readonly HttpClient _httpClient;
        public WebPaginasmaeServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<WebPaginasmae>?> GetWebPaginasmae(short codMae)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WebPaginasmae>>($"api/WebPaginasmaes/{codMae}");
        }
    }
    public interface IWebPaginasmaeServices
    {
        Task<IEnumerable<WebPaginasmae>?> GetWebPaginasmae(short codMae);
    }
}
