using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTipconsServices: IRhhTipconsServices
    {
        private readonly HttpClient _httpClient;
        public RhhTipconsServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTipcon>?> GetTipCon()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTipcon>>($"api/RhhTipcons");
        }
    }
    public interface IRhhTipconsServices
    {
        Task<IEnumerable<RhhTipcon>?> GetTipCon();
    }
}
