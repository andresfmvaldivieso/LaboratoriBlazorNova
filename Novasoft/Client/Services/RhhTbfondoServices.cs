using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbfondoServices: IRhhTbfondoServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbfondoServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbfondo>?> GetRhhTbfondo()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbfondo>>($"api/RhhTbfondoes");
        }
    }
    public interface IRhhTbfondoServices
    {
        Task<IEnumerable<RhhTbfondo>?> GetRhhTbfondo();
    }
}
