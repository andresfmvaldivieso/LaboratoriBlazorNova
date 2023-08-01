using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbTipTrabajosServices: IRhhTbTipTrabajosServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbTipTrabajosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbTipTrabajo>?> GetTipTrabajo()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbTipTrabajo>>($"api/RhhTbTipTrabajos");
        }
    }
    public interface IRhhTbTipTrabajosServices
    {
        Task<IEnumerable<RhhTbTipTrabajo>?> GetTipTrabajo();
    }
}
