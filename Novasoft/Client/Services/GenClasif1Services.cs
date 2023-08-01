using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif1Services: IGenClasif1Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif1Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif1>?> GetGenClasif1()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif1>>($"api/GenClasif1");
        }
    }
    public interface IGenClasif1Services
    {
        Task<IEnumerable<GenClasif1>?> GetGenClasif1();
    }
}
