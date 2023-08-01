using Novasoft.Server.Data;
using Novasoft.Shared.Models;
using System.Net.Http.Json;

namespace Novasoft.Client.Services
{
    public class UserLoginServices: IUserLoginServices
    {
        private readonly HttpClient _httpClient;
        public UserLoginServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task GetLogin(UserLogin userLogin)
        {
           var result =await _httpClient.PostAsJsonAsync<UserLogin>($"api/UsersLogin", userLogin);
            var bb = result;
        }
    }
    public interface IUserLoginServices
    {
        Task GetLogin(UserLogin userLogin);


    }
}