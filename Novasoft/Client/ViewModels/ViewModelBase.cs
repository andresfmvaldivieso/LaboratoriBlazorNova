using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Novasoft.Server.Data;
using Radzen;

namespace Novasoft.Client.ViewModels
{
    public class ViewModelBase<T>: ComponentBase
    {
        public T Model { get; set; }
        public bool popup;
        public bool isLoading = false;
        public IList<T> selectedModel { get; set; }
        protected  override Task OnInitializedAsync()
        {
            Model=Model ?? Activator.CreateInstance<T>();
            return base.OnInitializedAsync();
        }
    }
}
