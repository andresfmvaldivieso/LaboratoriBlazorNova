using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbModLiqServices: IRhhTbModLiqServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbModLiqServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbModLiq>?> GetRhhTbModLiq()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbModLiq>>($"api/RhhTbModLiqes");
        }
    }
    public interface IRhhTbModLiqServices
    {
        Task<IEnumerable<RhhTbModLiq>?> GetRhhTbModLiq();
    }
}
