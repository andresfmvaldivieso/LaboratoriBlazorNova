using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbestlabServices: IRhhTbestlabServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbestlabServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbestlab>?> GetRhhTbestlab()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbestlab>>($"api/RhhTbestlabs");
        }
    }
    public interface IRhhTbestlabServices
    {
        Task<IEnumerable<RhhTbestlab>?> GetRhhTbestlab();
    }
}
