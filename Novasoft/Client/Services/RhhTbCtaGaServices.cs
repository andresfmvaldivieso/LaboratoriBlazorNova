using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbCtaGaServices: IRhhTbCtaGaServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbCtaGaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbCtaGa>?> GetRhhTbCtaGa()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbCtaGa>>($"api/RhhTbCtaGas");
        }
    }
    public interface IRhhTbCtaGaServices
    {
        Task<IEnumerable<RhhTbCtaGa>?> GetRhhTbCtaGa();
    }
}
