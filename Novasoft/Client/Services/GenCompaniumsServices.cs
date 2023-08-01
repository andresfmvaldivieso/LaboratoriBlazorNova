using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenCompaniumsServices: IGenCompaniumsServices
    {
        private readonly HttpClient _httpClient;
        public GenCompaniumsServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenCompanium>?> GetGenCompanium()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenCompanium>>($"api/GenCompaniums");
        }
    }
    public interface IGenCompaniumsServices
    {
        Task<IEnumerable<GenCompanium>?> GetGenCompanium();
    }
}
