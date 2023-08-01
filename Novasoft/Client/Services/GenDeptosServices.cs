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
        public async Task<IEnumerable<gen_deptos>?> GetDeptos()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<gen_deptos>>($"api/GenDeptoes");
        }
    }
    public interface IGenDeptosServices
    {
        Task<IEnumerable<gen_deptos>?> GetDeptos();
    }
}
