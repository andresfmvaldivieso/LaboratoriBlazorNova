using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenCcostosServices: IGenCcostosServices
    {
        private readonly HttpClient _httpClient;
        public GenCcostosServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenCcosto>?> GetGenCcosto()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenCcosto>>($"api/GenCcostos");
        }
    }
    public interface IGenCcostosServices
    {
        Task<IEnumerable<GenCcosto>?> GetGenCcosto();
    }
}
