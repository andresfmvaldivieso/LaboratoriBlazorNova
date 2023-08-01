using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenClasif4Services : IGenClasif4Services
    {
        private readonly HttpClient _httpClient;
        public GenClasif4Services(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenClasif4>?> GetGenClasif4()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenClasif4>>($"api/GenClasif4");
        }
    }
    public interface IGenClasif4Services
    {
        Task<IEnumerable<GenClasif4>?> GetGenClasif4();
    }
}
