using Microsoft.AspNetCore.Components;

namespace Novasoft.Client.ViewModels
{
    public class ViewModelBase<T>: ComponentBase
    {
        public T Model { get; set; }

        protected  override Task OnInitializedAsync()
        {
            Model=Model ?? Activator.CreateInstance<T>();
            return base.OnInitializedAsync();
        }
    }
}
