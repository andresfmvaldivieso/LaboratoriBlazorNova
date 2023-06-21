using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbTipPagosServices : IRhhTbTipPagosServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbTipPagosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbTipPag>?> GetFormapago()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbTipPag>>($"api/RhhTbTipPagos");
        }
    }
    public interface IRhhTbTipPagosServices
    {
        Task<IEnumerable<RhhTbTipPag>?> GetFormapago();
    }
}
