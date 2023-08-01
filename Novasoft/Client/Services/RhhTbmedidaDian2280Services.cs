using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbmedidaDian2280Services: IRhhTbmedidaDian2280Services
    {
        private readonly HttpClient _httpClient;
        public RhhTbmedidaDian2280Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbmedidaDian2280>?> GetRhhTbmedidaDian2280()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbmedidaDian2280>>($"api/RhhTbmedidaDian2280");
        }
    }
    public interface IRhhTbmedidaDian2280Services
    {
        Task<IEnumerable<RhhTbmedidaDian2280>?> GetRhhTbmedidaDian2280();
    }
}
