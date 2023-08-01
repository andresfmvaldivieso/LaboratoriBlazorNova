using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbTipCotizaServices: IRhhTbTipCotizaServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbTipCotizaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbTipCotiza>?> GetRhhTbTipCotiza()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbTipCotiza>>($"api/RhhTbTipCotizaes");
        }
    }
    public interface IRhhTbTipCotizaServices
    {
        Task<IEnumerable<RhhTbTipCotiza>?> GetRhhTbTipCotiza();
    }
}
