using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Novasoft.Client.Services;
using Novasoft.Server.Data;
using Radzen;
using Radzen.Blazor;

namespace Novasoft.Client.ViewModels
{
    [Authorize]
    public class PaisesViewModel : ViewModelBase<GenPaise>
    {
        [Inject]
        private IGenPaiseServices GenPaiseServices { get; set; }

        public IEnumerable<GenPaise> Paises;

        public RadzenDataGrid<GenPaise> Grid;
        public bool VisibleData { get; set; } = true;
        protected async override Task OnParametersSetAsync()
        {
            await GetPaises();
            await base.OnParametersSetAsync();
        }

        public  async Task GetPaises()
        {
            try
            {
                Paises = await GenPaiseServices.GetPaises();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
        public async Task SavePaises()
        {
            try
            {
                await GenPaiseServices.SavePaises(Model);
                StateHasChanged();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
        public void Agregar()
        {
            VisibleData=false;
        }
        public void Cancelar()
        {
            VisibleData=true;
        }
    }
}
