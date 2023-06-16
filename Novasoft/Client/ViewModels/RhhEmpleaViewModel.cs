using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Primitives;
using Novasoft.Client.Services;
using Novasoft.Server.Data;
using Radzen;
using System;
using System.Linq;

namespace Novasoft.Client.ViewModels
{
    [Authorize]
    public class RhhEmpleaViewModel : ViewModelBase<RhhEmplea>
    {
        [Inject]
        private IGenTipideServices genTipIdenServices { get; set; }
        [Inject]
        private IGthEstCivilServices gthEstCivilServices { get; set; }
        [Inject]
        private IGthGenerosServices gthGenerosServices { get; set; }

        #region Tipo Identificacion

        public IEnumerable<GenTipide> tipoIdent;
        public int countTipoIde;
        public async void LoadData(LoadDataArgs args)
        {
            IEnumerable<GenTipide>? query = new List<GenTipide>();
            try
            {
                 query = await genTipIdenServices.GetTipIde();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodTip.ToLower().Contains(args.Filter.ToLower()) || c.DesTip.ToLower().Contains(args.Filter.ToLower()));
            }

            countTipoIde = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            tipoIdent = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region Genero

        public IEnumerable<GthGenero> genero;
        public int countGenero;
        public async Task LoadDataGenero(LoadDataArgs args)
        {
            IEnumerable<GthGenero>? query = new List<GthGenero>();
            try
            {
                query = await gthGenerosServices.GetGthGen();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.DesGen.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenero = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genero = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion
        #region EstCivil
        #endregion

        public void PaisDepartamentoCiudadExpedicion((string, string, string) eventArgs)
        {
            Model.PaiExp = eventArgs.Item1;
            Model.CiuExp = eventArgs.Item3;
        }
        public void PaisDepartamentoCiudadNacimiento((string, string, string) eventArgs)
        {
            Model.CodPai = eventArgs.Item1;
            Model.CodDep = eventArgs.Item2;
            Model.CodCiu = eventArgs.Item3;
        }

    }
}
