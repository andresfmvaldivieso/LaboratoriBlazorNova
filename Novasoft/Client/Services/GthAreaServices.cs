using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GthAreaServices: IGthAreaServices
    {
        private readonly HttpClient _httpClient;
        public GthAreaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GthArea>?> GetGthArea()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GthArea>>($"api/GthAreas");
        }
    }
    public interface IGthAreaServices
    {
        Task<IEnumerable<GthArea>?> GetGthArea();
    }
}
