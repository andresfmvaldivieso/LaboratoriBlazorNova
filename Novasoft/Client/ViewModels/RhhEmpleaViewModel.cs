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
        [Inject]
        private IGenPaiseServices genPaiseServices { get; set; }
        [Inject]
        private IRhhTbTipPagosServices rhhTbTipPagosServices { get; set; }

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

        public int codEstCivil { get; set; }
        public IEnumerable<GthEstCivil> estCivil;
        public int countEstCivil;
        public async Task LoadDataEstCivil(LoadDataArgs args)
        {
            IEnumerable<GthEstCivil>? query = new List<GthEstCivil>();
            try
            {
                query = await gthEstCivilServices.GetEstCivil();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.DesEst.ToLower().Contains(args.Filter.ToLower()));
            }

            countEstCivil = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            estCivil = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Pais Emision

        public IEnumerable<GenPaise>? paises;

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
        #endregion

        #region Clase Libreta Militar
        public List<object> clasesLib = new() { new { codClaseLib = 0, nomClaseLib = "No Aplica"},new { codClaseLib = 1, nomClaseLib = "Primera" },new { codClaseLib = 2, nomClaseLib = "Segunda" } };
        #endregion

        #region Nacionalidad
        public List<object> nacionalidades = new() { new { codNac = 1, nomNac = "Colombiano" }, new { codNac = 2, nomNac = "Doble" }, new { codNac = 3, nomNac = "Extranjero" } };
        #endregion

        #region Grupo Sanguineo
        public List<string> gruposSang = new() { "A", "B", "AB", "O" };
        #endregion

        #region Factor rh
        public List<string> factorRh = new() { "+", "-"};
        #endregion

        #region Regimen Salarial

        public List<object> regimenSal = new() { new { codRegSal = 1, nomRegSal = "Anterior" }, new { codRegSal = 2, nomRegSal = "Ley 50" } };

        #endregion

        #region Formas Pago
        public IEnumerable<RhhTbTipPag> formasPagos;
        public int countFormasPago;
        public async void LoadDataFormasPago(LoadDataArgs args)
        {
            IEnumerable<RhhTbTipPag>? query = new List<RhhTbTipPag>();
            try
            {
                query = await rhhTbTipPagosServices.GetFormapago();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.NomPag.ToLower().Contains(args.Filter.ToLower()));
            }

            countFormasPago = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            formasPagos = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region EventCallBack

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
        public void PaisDepartamentoCiudadResidencia((string, string, string) eventArgs)
        {
            Model.PaiRes = eventArgs.Item1;
            Model.DptRes = eventArgs.Item2;
            Model.CiuRes = eventArgs.Item3;
        }
        #endregion
        public void Save()
        {

        }
    }
}
