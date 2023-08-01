using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Novasoft.Client.Services;
using Novasoft.Server.Data;

namespace Novasoft.Client.ViewModels
{
    [Authorize]
    public class DeptosViewModel:ViewModelBase<gen_deptos>
    {
        [Inject]
        private IGenDeptosServices GenDeptosServices { get; set; }
        public IEnumerable<gen_deptos> Deptos;

        [Parameter]
        public string CodigoPais { get; set; }
        protected async override Task OnParametersSetAsync()
        {
            await GetDeptos();
            await base.OnParametersSetAsync();
        }
        public async Task GetDeptos()
        {
            try
            {
                Deptos = await GenDeptosServices.GetDeptos();
                
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
    }
}
