using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenCiudadesServices: IGenCiudadesServices
    {
        private readonly HttpClient _httpClient;
        public GenCiudadesServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenCiudad>?> GetCiudades()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenCiudad>>($"api/GenCiudads");
        }
    }
    public interface IGenCiudadesServices
    {
        Task<IEnumerable<GenCiudad>?> GetCiudades();
    }
}
