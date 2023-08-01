using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif3Services : IGenClasif3Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif3Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif3>?> GetGenClasif3()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif3>>($"api/GenClasif3");
        }
    }
    public interface IGenClasif3Services
    {
        Task<IEnumerable<GenClasif3>?> GetGenClasif3();
    }
}
