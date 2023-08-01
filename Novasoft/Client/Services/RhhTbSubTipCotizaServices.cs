using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhTbSubTipCotizaServices: IRhhTbSubTipCotizaServices
    {
        private readonly HttpClient _httpClient;
        public RhhTbSubTipCotizaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RhhTbSubTipCotiza>?> GetRhhTbSubTipCotiza()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<RhhTbSubTipCotiza>>($"api/RhhTbSubTipCotizaes");
        }
    }
    public interface IRhhTbSubTipCotizaServices
    {
        Task<IEnumerable<RhhTbSubTipCotiza>?> GetRhhTbSubTipCotiza();
    }
}
