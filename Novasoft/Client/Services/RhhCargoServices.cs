using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhCargoServices: IRhhCargoServices
    {
        private readonly HttpClient _httpClient;
        public RhhCargoServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhCargo>?> GetRhhCargo()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhCargo>>($"api/RhhCargoes");
        }
    }
    public interface IRhhCargoServices
    {
        Task<IEnumerable<RhhCargo>?> GetRhhCargo();
    }
}
