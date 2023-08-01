using Novasoft.Server.Data;
using Radzen;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class RhhEmpleaServices: IRhhEmpleaServices
    {
        private readonly HttpClient _httpClient;
        public RhhEmpleaServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ODataServiceResult<RhhEmplea>?> GetRhhEmplea()
        {
            return await _httpClient.GetFromJsonAsync<ODataServiceResult<RhhEmplea>>($"api/RhhEmpleas");
        }
        public async Task SaveEmplea(RhhEmplea rhhEmplea)
        {
            await _httpClient.PostAsJsonAsync<RhhEmplea>($"api/RhhEmpleas", rhhEmplea);
        }
    }
    public interface IRhhEmpleaServices
    {
        Task<ODataServiceResult<RhhEmplea>?> GetRhhEmplea();
        Task SaveEmplea(RhhEmplea rhhEmplea);
    }
}
