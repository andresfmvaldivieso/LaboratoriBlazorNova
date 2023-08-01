using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhCentroTrabServices: IRhhCentroTrabServices
    {
        private readonly HttpClient _httpClient;
        public RhhCentroTrabServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhCentroTrab>?> GetRhhCentroTrab()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhCentroTrab>>($"api/RhhCentroTrabs");
        }
    }
    public interface IRhhCentroTrabServices
    {
        Task<IEnumerable<RhhCentroTrab>?> GetRhhCentroTrab();
    }
}
