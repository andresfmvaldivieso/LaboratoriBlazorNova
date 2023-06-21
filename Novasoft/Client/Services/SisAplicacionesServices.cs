using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class SisAplicacionesServices: ISisAplicacionesServices
    {

        private readonly HttpClient _httpClient;
        public SisAplicacionesServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<SisAplicacion>?> GetSisAplicaciones()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<SisAplicacion>>($"api/SisApliacaciones");
        }
    }
    public interface ISisAplicacionesServices
    {
        Task<IEnumerable<SisAplicacion>?> GetSisAplicaciones();
    }
}
