using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif2Services : IGenClasif2Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif2Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif2>?> GetGenClasif2()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif2>>($"api/GenClasif2");
        }
    }
    public interface IGenClasif2Services
    {
        Task<IEnumerable<GenClasif2>?> GetGenClasif2();
    }
}
