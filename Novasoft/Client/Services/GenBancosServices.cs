using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenBancosServices: IGenBancosServices
    {
        private readonly HttpClient _httpClient;
        public GenBancosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenBanco>?> GetBancos()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenBanco>>($"api/GenBancos");
        }
    }
    public interface IGenBancosServices
    {
        Task<IEnumerable<GenBanco>?> GetBancos();
    }
}
