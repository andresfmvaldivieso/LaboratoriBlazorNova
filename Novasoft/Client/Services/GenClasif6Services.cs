using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif6Services : IGenClasif6Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif6Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif6>?> GetGenClasif6()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif6>>($"api/GenClasif6");
        }
    }
    public interface IGenClasif6Services
    {
        Task<IEnumerable<GenClasif6>?> GetGenClasif6();
    }
}
