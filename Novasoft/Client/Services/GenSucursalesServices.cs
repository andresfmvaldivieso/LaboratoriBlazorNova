using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenSucursalesServices: IGenSucursalesServices
    {
        private readonly HttpClient _httpClient;
        public GenSucursalesServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenSucursal>?> GetGenSucursal()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenSucursal>>($"api/GenSucursales");
        }
    }
    public interface IGenSucursalesServices
    {
        Task<IEnumerable<GenSucursal>?> GetGenSucursal();
    }
}
