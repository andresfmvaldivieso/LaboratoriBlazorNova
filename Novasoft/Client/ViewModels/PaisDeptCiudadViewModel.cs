using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Primitives;
using Novasoft.Client.Services;
using Novasoft.Server.Data;
using Radzen;

namespace Novasoft.Client.ViewModels
{
    [Authorize]
    public class PaisDeptCiudadViewModel : ComponentBase
    {
        [Inject]
        private IGenPaiseServices genPaiseServices { get; set; }

        [Inject]
        private IGenDeptosServices genDeptosServices { get; set; }

        [Inject]
        private IGenCiudadesServices genCiudadesServices { get; set; }

        [Parameter]
        public EventCallback<(string,string,string)> LocalizacionChange { get; set; }

        public IEnumerable<GenPaise>? paises;
        public string paisSelected { get; set; }

        public int countPaises;
        public async Task LoadDataPaises(LoadDataArgs args)
        {
            IEnumerable<GenPaise>? query = new List<GenPaise>();
            try
            {
                query = await genPaiseServices.GetPaises();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodPai.ToLower().Contains(args.Filter.ToLower()) || c.NomPai.ToLower().Contains(args.Filter.ToLower()));
            }

            countPaises = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            paises = query.ToList();

            InvokeAsync(StateHasChanged);
        }


        public IEnumerable<GenDepto>? deptos;
        public string deptoSelected { get; set; }

        public int countDeptos;

        public async Task LoadDataDeptos(LoadDataArgs args)
        {
            IEnumerable<GenDepto>? query = new List<GenDepto>();
            try
            {
                if (!String.IsNullOrEmpty(paisSelected))
                    query = await genDeptosServices.GetDeptos();

                query=query?.Where(x => x.CodPai == paisSelected);
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodDep.ToLower().Contains(args.Filter.ToLower()) || c.NomDep.ToLower().Contains(args.Filter.ToLower()));
            }

            countDeptos = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            deptos = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        public IEnumerable<GenCiudad>? ciudades;
        public string ciudadSelected { get; set; }

        public int countCiudad;

        public async Task LoadDataCiudades(LoadDataArgs args)
        {
            IEnumerable<GenCiudad>? query = new List<GenCiudad>();
            try
            {
                if (!String.IsNullOrEmpty(deptoSelected))
                    query = await genCiudadesServices.GetCiudades();

                query = query?.Where(x => x.CodPai==paisSelected && x.CodDep == deptoSelected);
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodCiu.ToLower().Contains(args.Filter.ToLower()) || c.NomCiu.ToLower().Contains(args.Filter.ToLower()));
            }

            countCiudad = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            ciudades = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        public void CiudadChange(dynamic args)
        {
            LocalizacionChange.InvokeAsync((paisSelected, deptoSelected, ciudadSelected));
        }
    }
}
