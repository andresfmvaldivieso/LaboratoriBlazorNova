using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif7Services : IGenClasif7Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif7Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif7>?> GetGenClasif7()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif7>>($"api/GenClasif7");
        }
    }
    public interface IGenClasif7Services
    {
        Task<IEnumerable<GenClasif7>?> GetGenClasif7();
    }
}
