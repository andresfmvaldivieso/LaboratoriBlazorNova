using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class WebGridmaestroServices: IWebGridmaestroServices
    {
        private readonly HttpClient _httpClient;
        public WebGridmaestroServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<WebGridmaestro>?> GetWebGridmaestro(short codApl)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<WebGridmaestro>>($"api/WebGridmaestros/{codApl}");
        }
    }
    public interface IWebGridmaestroServices
    {
        Task<IEnumerable<WebGridmaestro>?> GetWebGridmaestro(short codApl);
    }
}
