using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class WebMaestrosgenServices: IWebMaestrosgenServices
    {
        private readonly HttpClient _httpClient;
        public WebMaestrosgenServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<WebMaestrosgen> GetWebMaestrosgen(short codMae)
        {
            return await _httpClient.GetFromJsonAsync<WebMaestrosgen>($"api/WebMaestrosGens/{codMae}");
        }
    }
    public interface IWebMaestrosgenServices
    {
        Task<WebMaestrosgen> GetWebMaestrosgen(short codMae);
    }
}
