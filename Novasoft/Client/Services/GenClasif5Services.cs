using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif5Services : IGenClasif5Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif5Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif5>?> GetGenClasif5()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif5>>($"api/GenClasif5");
        }
    }
    public interface IGenClasif5Services
    {
        Task<IEnumerable<GenClasif5>?> GetGenClasif5();
    }
}
