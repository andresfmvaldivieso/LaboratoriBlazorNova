using Novasoft.Server.Data;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GenTipideServices: IGenTipideServices
    {

        private readonly HttpClient _httpClient;
        public GenTipideServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenTipide>?> GetTipIde()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenTipide>>($"api/GenTipides");
        }
    }
    public interface IGenTipideServices
    {
        Task<IEnumerable<GenTipide>?> GetTipIde();
    }
}
