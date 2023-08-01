using Novasoft.Server.Data;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class GeneralServices<T>
    {
        private readonly HttpClient _httpClient;
        public GeneralServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IEnumerable<T> BuscarTodos()
        {
            return Task.Run(async () => await BuscarTodosAsync()).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<T>> BuscarTodosAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>>($"api/{typeof(T).Name}");
        }
    }
}
