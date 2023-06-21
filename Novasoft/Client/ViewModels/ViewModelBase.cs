using Microsoft.AspNetCore.Components;
using Novasoft.Server.Data;

namespace Novasoft.Client.ViewModels
{
    public class ViewModelBase<T>: ComponentBase
    {
        public T Model { get; set; }
        public bool popup;
        protected  override Task OnInitializedAsync()
        {
            Model=Model ?? Activator.CreateInstance<T>();
            return base.OnInitializedAsync();
        }
    }
}
