using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenDeptosServices: IGenDeptosServices
    {
        private readonly HttpClient _httpClient;
        public GenDeptosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenDepto>?> GetDeptos()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenDepto>>($"api/GenDeptoes");
        }
    }
    public interface IGenDeptosServices
    {
        Task<IEnumerable<GenDepto>?> GetDeptos();
    }
}
