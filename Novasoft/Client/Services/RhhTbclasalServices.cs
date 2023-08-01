using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbclasalServices: IRhhTbclasalServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbclasalServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbclasal>?> GetRhhTbclasal()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbclasal>>($"api/RhhTbclasales");
        }
    }
    public interface IRhhTbclasalServices
    {
        Task<IEnumerable<RhhTbclasal>?> GetRhhTbclasal();
    }
}
