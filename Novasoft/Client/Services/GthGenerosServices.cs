using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GthGenerosServices: IGthGenerosServices
    {

        private readonly HttpClient _httpClient;
        public GthGenerosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GthGenero>?> GetGthGen()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GthGenero>>($"api/GthGeneroes");
        }
    }
    public interface IGthGenerosServices
    {
        Task<IEnumerable<GthGenero>?> GetGthGen();
    }
}
