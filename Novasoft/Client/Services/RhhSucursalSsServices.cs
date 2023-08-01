using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhSucursalSsServices: IRhhSucursalSsServices
    {
        private readonly HttpClient _httpClient;
        public RhhSucursalSsServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhSucursalSs>?> GetRhhSucursalSs()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhSucursalSs>>($"api/RhhSucursalSss");
        }
    }
    public interface IRhhSucursalSsServices
    {
        Task<IEnumerable<RhhSucursalSs>?> GetRhhSucursalSs();
    }
}
