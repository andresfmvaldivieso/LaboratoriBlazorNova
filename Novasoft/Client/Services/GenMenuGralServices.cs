using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenMenuGralServices: IGenMenuGralServices
    {
        private readonly HttpClient _httpClient;
        public GenMenuGralServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenMenuGral>?> GetGenMenuGral(string codApl)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenMenuGral>>($"api/GenMenuGral/{codApl}");
        }
    }
    public interface IGenMenuGralServices
    {
        Task<IEnumerable<GenMenuGral>?> GetGenMenuGral(string codApl);
    }
}
