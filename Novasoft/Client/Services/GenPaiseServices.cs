using Novasoft.Server.Data;
using System.Net.Http.Json;
using System.Text.Json;

namespace Novasoft.Client.Services
{
    public class GenPaiseServices : IGenPaiseServices
    {
        private readonly HttpClient _httpClient;
        public GenPaiseServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<GenPaise>?> GetPaises()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GenPaise>>($"api/GenPaise");
        }
        public async Task SavePaises(GenPaise genPaise)
        {
            await _httpClient.PostAsJsonAsync<GenPaise>($"api/GenPaise", genPaise);
        }
    }

    public interface IGenPaiseServices
    {
        Task<IEnumerable<GenPaise>?> GetPaises();
        Task SavePaises(GenPaise genPaise);
    }
}
