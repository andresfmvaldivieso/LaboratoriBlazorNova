using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GthEstCivilServices: IGthEstCivilServices
    {

        private readonly HttpClient _httpClient;
        public GthEstCivilServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GthEstCivil>?> GetEstCivil()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GthEstCivil>>($"api/GthEstCivil");
        }
    }
    public interface IGthEstCivilServices
    {
        Task<IEnumerable<GthEstCivil>?> GetEstCivil();
    }
}
