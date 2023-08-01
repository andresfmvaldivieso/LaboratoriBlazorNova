using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Primitives;
using Novasoft.Client.Services;
using Novasoft.Server.Data;
using Radzen;
using Radzen.Blazor;
using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;

namespace Novasoft.Client.ViewModels
{
    [Authorize]
    public class RhhEmpleaViewModel : ViewModelBase<RhhEmplea>
    {

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }

        #region Inject
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
        [Inject]
        private IGenBancosServices genBancosServices { get; set; }
        [Inject]
        private IRhhTipconsServices rhhTipconsServices { get; set; }
        [Inject]
        private IRhhTbTipTrabajosServices rhhTbTipTrabajosServices { get; set; }
        [Inject]
        private IRhhTbestlabServices rhhTbestlabServices { get; set; }
        [Inject]
        private IRhhEmpleaServices rhhEmpleaServices { get; set; }
        [Inject]
        private IGenClasif1Services genClasif1Services { get; set; }
        [Inject]
        private IGenClasif2Services genClasif2Services { get; set; }
        [Inject]
        private IGenClasif3Services genClasif3Services { get; set; }
        [Inject]
        private IGenClasif4Services genClasif4Services { get; set; }
        [Inject]
        private IGenClasif5Services genClasif5Services { get; set; }
        [Inject]
        private IGenClasif6Services genClasif6Services { get; set; }
        [Inject]
        private IGenClasif7Services genClasif7Services { get; set; }
        [Inject]
        private IGenCompaniumsServices genCompaniumsServices { get; set; }
        [Inject]
        private IGenSucursalesServices genSucursalesServices { get; set; }
        [Inject]
        private IGenCcostosServices genCcostosServices { get; set; }
        [Inject]
        private IRhhTbCtaGaServices rhhTbCtaGaServices { get; set; }
        [Inject]
        private IRhhCentroTrabServices rhhCentroTrabServices { get; set; }
        [Inject]
        private IRhhSucursalSsServices rhhSucursalSsServices { get; set; }
        [Inject]
        private IGthAreaServices gthAreaServices { get; set; }
        [Inject]
        private IRhhCargoServices rhhCargoServices { get; set; }
        [Inject]
        private IRhhTbModLiqServices rhhTbModLiqServices { get; set; }
        [Inject]
        private IRhhTbclasalServices rhhTbclasalServices { get; set; }
        [Inject]
        private IRhhTbfondoServices rhhTbfondoServices { get; set; }
        [Inject]
        private IRhhTbmedidaDian2280Services rhhTbmedidaDian2280Services { get; set; }
        [Inject]
        private IRhhTbTipCotizaServices rhhTbTipCotizaServices { get; set; }
        [Inject]
        private IRhhTbSubTipCotizaServices rhhTbSubTipCotizaServices { get; set; }

        #endregion

        #region Variables Miselaneas
        public bool indSab { get; set; }
        public bool pagoDia { get; set; }
        public string numCont { get; set; }
        public DateTime fecCont { get; set; }
        public string paiCon { get; set; }
        public string depCon { get; set; }
        public string ciucon { get; set; }
        public string notCon { get; set; }
        public decimal dedViv { get; set; }
        public decimal dedSal { get; set; }
        public bool indDep { get; set; }

        private int autorizaControl;
        public int autoriza
        {
            get => autorizaControl;
            set
            {
                autorizaControl = value;
                Model.AutDat = Convert.ToByte(value);
            }
        }
        public bool IndDiscco { get; set; }
        public bool IndDiscconif { get; set; }

        public string codArea { get; set; }

        public string codsucSS { get; set; }

        public int codCT { get; set; }

        public string observacion { get; set; }

        public string PaiLab { get; set; }
        public string DepLab { get; set; }
        public string CiuLab { get; set; }

        public DateTime FecIng { get; set; }
        public DateTime FecFin { get; set; }

        public int DiasPerPba { get; set; }

        public DateTime FecFinPerPba { get; set; }
        public string FdoArp { get; set; }

        public bool IndSvar { get; set; }
        #endregion

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
        private int? codEstCivilControl;
        public int? codEstCivil
        {
            get => codEstCivilControl;
            set
            {
                codEstCivilControl = value;
                Model.EstCiv = value is null ? null : Convert.ToInt16(value);
            }
        }
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
        public List<object> clasesLib = new() { new { codClaseLib = (short)0, nomClaseLib = "No Aplica" }, new { codClaseLib = (short)1, nomClaseLib = "Primera" }, new { codClaseLib = (short)2, nomClaseLib = "Segunda" } };
        #endregion

        #region Nacionalidad
        public List<object> nacionalidades = new() { new { codNac = (short)1, nomNac = "Colombiano" }, new { codNac = (short)2, nomNac = "Doble" }, new { codNac = (short)3, nomNac = "Extranjero" } };
        #endregion

        #region Grupo Sanguineo
        public List<string> gruposSang = new() { "A", "B", "AB", "O" };
        #endregion

        #region Factor rh
        public List<string> factorRh = new() { "+", "-" };
        #endregion

        #region Regimen Salarial

        public List<object> regimenSal = new() { new { codRegSal = (short)1, nomRegSal = "Anterior" }, new { codRegSal = (short)2, nomRegSal = "Ley 50" } };

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

        #region Bancos
        public IEnumerable<GenBanco> bancos;
        public int countBanco;
        public async void LoadDataBanco(LoadDataArgs args)
        {
            IEnumerable<GenBanco>? query = new List<GenBanco>();
            try
            {
                query = await genBancosServices.GetBancos();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodBan.ToLower().Contains(args.Filter.ToLower()) || c.NomBan.ToLower().Contains(args.Filter.ToLower()));
            }

            countBanco = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            bancos = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Modalidad Ret
        public List<object> modalidadRet = new() { new { codModRet = (short)1, nomModRet = " Modalidad 1" }, new { codModRet = (short)2, nomModRet = " Modalidad 2" } };
        #endregion

        #region Indicador Declarante Renta
        public List<object> indDecRen = new() { new { codIndDecRen = "0", nomIndDecRen = " No Aplica" }, new { codIndDecRen = "1", nomIndDecRen = "Aplica" }, new { codIndDecRen = "2", nomIndDecRen = "Trabajador por Cuenta Propia" } };
        #endregion

        #region Vacaciones
        public List<object> indVac = new() { new { codIndVac = (short)1, nomIndVac = "Individuales" }, new { codIndVac = (short)2, nomIndVac = "Colectivas" } };
        #endregion

        #region Tipo contrato

        public IEnumerable<RhhTipcon> tipCon;
        public int countTipCon;
        public async void LoadDataTipCon(LoadDataArgs args)
        {
            IEnumerable<RhhTipcon>? query = new List<RhhTipcon>();
            try
            {
                query = await rhhTipconsServices.GetTipCon();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.TipCon.ToLower().Contains(args.Filter.ToLower()) || c.NomCon.ToLower().Contains(args.Filter.ToLower()));
            }

            countTipCon = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            tipCon = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region Tipo Trabajo
        public byte tipTrabajo { get; set; }

        public IEnumerable<RhhTbTipTrabajo> tipoTrabajo;

        public async void LoadDataTipTrabajo(LoadDataArgs args)
        {
            IEnumerable<RhhTbTipTrabajo>? query = new List<RhhTbTipTrabajo>();
            try
            {
                query = await rhhTbTipTrabajosServices.GetTipTrabajo();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Descripcion.ToLower().Contains(args.Filter.ToLower()));
            }

            tipoTrabajo = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Estado Laboral

        public IEnumerable<RhhTbestlab> estLab;
        public int countEstLab;
        public async void LoadDataEstLab(LoadDataArgs args)
        {
            IEnumerable<RhhTbestlab>? query = new List<RhhTbestlab>();
            try
            {
                query = await rhhTbestlabServices.GetRhhTbestlab();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.EstLab.ToLower().Contains(args.Filter.ToLower()) || c.NomEst.ToLower().Contains(args.Filter.ToLower()));
            }

            countEstLab = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            estLab = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif1

        public IEnumerable<GenClasif1> genClasif1;
        public int countGenClasif1;
        public async void LoadDataGenClasif1(LoadDataArgs args)
        {
            IEnumerable<GenClasif1>? query = new List<GenClasif1>();
            try
            {
                query = await genClasif1Services.GetGenClasif1();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif1 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif1 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif2

        public IEnumerable<GenClasif2> genClasif2;
        public int countGenClasif2;
        public async void LoadDataGenClasif2(LoadDataArgs args)
        {
            IEnumerable<GenClasif2>? query = new List<GenClasif2>();
            try
            {
                query = await genClasif2Services.GetGenClasif2();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif2 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif2 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif3

        public IEnumerable<GenClasif3> genClasif3;
        public int countGenClasif3;
        public async void LoadDataGenClasif3(LoadDataArgs args)
        {
            IEnumerable<GenClasif3>? query = new List<GenClasif3>();
            try
            {
                query = await genClasif3Services.GetGenClasif3();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif3 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif3 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif4

        public IEnumerable<GenClasif4> genClasif4;
        public int countGenClasif4;
        public async void LoadDataGenClasif4(LoadDataArgs args)
        {
            IEnumerable<GenClasif4>? query = new List<GenClasif4>();
            try
            {
                query = await genClasif4Services.GetGenClasif4();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif4 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif4 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif5

        public IEnumerable<GenClasif5> genClasif5;
        public int countGenClasif5;
        public async void LoadDataGenClasif5(LoadDataArgs args)
        {
            IEnumerable<GenClasif5>? query = new List<GenClasif5>();
            try
            {
                query = await genClasif5Services.GetGenClasif5();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif5 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif5 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif6

        public IEnumerable<GenClasif6> genClasif6;
        public int countGenClasif6;
        public async void LoadDataGenClasif6(LoadDataArgs args)
        {
            IEnumerable<GenClasif6>? query = new List<GenClasif6>();
            try
            {
                query = await genClasif6Services.GetGenClasif6();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif6 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif6 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region GenClasif7

        public IEnumerable<GenClasif7> genClasif7;
        public int countGenClasif7;
        public async void LoadDataGenClasif7(LoadDataArgs args)
        {
            IEnumerable<GenClasif7>? query = new List<GenClasif7>();
            try
            {
                query = await genClasif7Services.GetGenClasif7();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Codigo.ToLower().Contains(args.Filter.ToLower()) || c.Nombre.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenClasif7 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genClasif7 = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Compañias
        public IEnumerable<GenCompanium> genCompaniums;
        public int countGenCompanium;
        public async void LoadDataGenCompanium(LoadDataArgs args)
        {
            IEnumerable<GenCompanium>? query = new List<GenCompanium>();
            try
            {
                query = await genCompaniumsServices.GetGenCompanium();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodCia.ToLower().Contains(args.Filter.ToLower()) || c.NomCia.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenCompanium = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genCompaniums = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Sucursal
        public IEnumerable<GenSucursal> genSucursales;
        public int countGenSucursal;
        public async void LoadDataGenSucursal(LoadDataArgs args)
        {
            IEnumerable<GenSucursal>? query = new List<GenSucursal>();
            try
            {
                query = await genSucursalesServices.GetGenSucursal();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodSuc.ToLower().Contains(args.Filter.ToLower()) || c.NomSuc.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenSucursal = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genSucursales = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Centro de costos
        public IEnumerable<GenCcosto> genCcostos;
        public int countGenCcosto;
        public async void LoadDataGenCcosto(LoadDataArgs args)
        {
            IEnumerable<GenCcosto>? query = new List<GenCcosto>();
            try
            {
                query = await genCcostosServices.GetGenCcosto();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodCco.ToLower().Contains(args.Filter.ToLower()) || c.NomCco.ToLower().Contains(args.Filter.ToLower()));
            }

            countGenCcosto = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            genCcostos = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Areas
        public IEnumerable<GthArea> gthAreas;
        public int countGthArea;
        public async void LoadDataGthArea(LoadDataArgs args)
        {
            IEnumerable<GthArea>? query = new List<GthArea>();
            try
            {
                query = await gthAreaServices.GetGthArea();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodArea.ToLower().Contains(args.Filter.ToLower()) || c.DesArea.ToLower().Contains(args.Filter.ToLower()));
            }

            countGthArea = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            gthAreas = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Sucursal SS
        public IEnumerable<RhhSucursalSs> rhhSucursalSss;
        public int countRhhSucursalSs;
        public async void LoadDataRhhSucursalSs(LoadDataArgs args)
        {
            IEnumerable<RhhSucursalSs>? query = new List<RhhSucursalSs>();
            try
            {
                query = await rhhSucursalSsServices.GetRhhSucursalSs();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.SucSs.ToLower().Contains(args.Filter.ToLower()) || c.Descripcion.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhSucursalSs = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhSucursalSss = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Centro de Trabajo
        public IEnumerable<RhhCentroTrab> rhhCentroTrabs;
        public int countRhhCentroTrab;
        public async void LoadDataRhhCentroTrab(LoadDataArgs args)
        {
            IEnumerable<RhhCentroTrab>? query = new List<RhhCentroTrab>();
            try
            {
                query = await rhhCentroTrabServices.GetRhhCentroTrab();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Descripcion.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhCentroTrab = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhCentroTrabs = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Cuenta Gastos
        public IEnumerable<RhhTbCtaGa> rhhTbCtaGas;
        public int countRhhTbCtaGa;
        public async void LoadDataRhhTbCtaGa(LoadDataArgs args)
        {
            IEnumerable<RhhTbCtaGa>? query = new List<RhhTbCtaGa>();
            try
            {
                query = await rhhTbCtaGaServices.GetRhhTbCtaGa();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.PreCtaGas.ToLower().Contains(args.Filter.ToLower()) || c.Descripcion.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbCtaGa = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbCtaGas = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Cargos

        public IEnumerable<RhhCargo> rhhCargos;
        public int countRhhCargo;
        public async void LoadDataRhhCargo(LoadDataArgs args)
        {
            IEnumerable<RhhCargo>? query = new List<RhhCargo>();
            try
            {
                query = await rhhCargoServices.GetRhhCargo();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodCar.ToLower().Contains(args.Filter.ToLower()) || c.NomCar.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhCargo = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhCargos = query.ToList();

            InvokeAsync(StateHasChanged);
        }
        #endregion

        #region Modo Liquidacion
        
        public IEnumerable<RhhTbModLiq> rhhTbModLiqes;
        public int countRhhTbModLiq;
        public async void LoadDataRhhTbModLiq(LoadDataArgs args)
        {
            IEnumerable<RhhTbModLiq>? query = new List<RhhTbModLiq>();
            try
            {
                query = await rhhTbModLiqServices.GetRhhTbModLiq();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.ModLiq.ToLower().Contains(args.Filter.ToLower()) || c.DesMod.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbModLiq = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbModLiqes = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region Clase Salario

        public IEnumerable<RhhTbclasal> rhhTbclasals;
        public int countRhhTbclasal;
        public async void LoadDataRhhTbclasal(LoadDataArgs args)
        {
            IEnumerable<RhhTbclasal>? query = new List<RhhTbclasal>();
            try
            {
                query = await rhhTbclasalServices.GetRhhTbclasal();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where( c=> c.Descripcion.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbclasal = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbclasals = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region Fondos

        public IEnumerable<RhhTbfondo> rhhTbfondos;
        public int countRhhTbfondo;
        public async void LoadDataRhhTbfondo(LoadDataArgs args)
        {
            IEnumerable<RhhTbfondo>? query = new List<RhhTbfondo>();
            try
            {
                query = await rhhTbfondoServices.GetRhhTbfondo();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.CodFdo.ToLower().Contains(args.Filter.ToLower()) || c.NomFdo.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbfondo = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbfondos = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region Medida Certificadas

        public IEnumerable<RhhTbmedidaDian2280> rhhTbmedidaDian2280s;
        public int countRhhTbmedidaDian2280;
        public async void LoadDataRhhTbmedidaDian2280(LoadDataArgs args)
        {
            IEnumerable<RhhTbmedidaDian2280>? query = new List<RhhTbmedidaDian2280>();
            try
            {
                query = await rhhTbmedidaDian2280Services.GetRhhTbmedidaDian2280();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.Concepto.ToLower().Contains(args.Filter.ToLower()) || c.Descripcion.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbmedidaDian2280 = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbmedidaDian2280s = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region Tipo Cotizante

        public IEnumerable<RhhTbTipCotiza> rhhTbTipCotizas;
        public int countRhhTbTipCotiza;
        public async void LoadDataRhhTbTipCotiza(LoadDataArgs args)
        {
            IEnumerable<RhhTbTipCotiza>? query = new List<RhhTbTipCotiza>();
            try
            {
                query = await rhhTbTipCotizaServices.GetRhhTbTipCotiza();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.TipCot.ToLower().Contains(args.Filter.ToLower()) || c.DesCot.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbTipCotiza = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbTipCotizas = query.ToList();

            InvokeAsync(StateHasChanged);
        }

        #endregion

        #region SubTipo Cotizante

        public IEnumerable<RhhTbSubTipCotiza> rhhTbSubTipCotizas;
        public int countRhhTbSubTipCotiza;
        public async void LoadDataRhhTbSubTipCotiza(LoadDataArgs args)
        {
            IEnumerable<RhhTbSubTipCotiza>? query = new List<RhhTbSubTipCotiza>();
            try
            {
                query = await rhhTbSubTipCotizaServices.GetRhhTbSubTipCotiza();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
            if (!string.IsNullOrEmpty(args.Filter))
            {
                query = query.Where(c => c.SubTipCot.ToLower().Contains(args.Filter.ToLower()) || c.DesSubTip.ToLower().Contains(args.Filter.ToLower()));
            }

            countRhhTbSubTipCotiza = query.Count();

            if (args.Skip != null)
            {
                query = query.Skip(args.Skip.Value);
            }

            if (args.Top != null)
            {
                query = query.Take(args.Top.Value);
            }

            rhhTbSubTipCotizas = query.ToList();

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
        public void PaisDepartamentoCiudadContratacion((string, string, string) eventArgs)
        {
            paiCon = eventArgs.Item1;
            depCon = eventArgs.Item2;
            ciucon = eventArgs.Item3;
        }
        public void PaisDepartamentoCiudadLabor((string, string, string) eventArgs)
        {
            PaiLab = eventArgs.Item1;
            DepLab = eventArgs.Item2;
            CiuLab = eventArgs.Item3;
        }

        #endregion

        #region DataContratacion

        public RadzenDataGrid<RhhEmplea> grid;
        public int count;
        public IEnumerable<RhhEmplea> rhhEmplea;
        public async Task LoadDataContratacion(LoadDataArgs args)
        {
            isLoading = true;
            
            var result = await rhhEmpleaServices.GetRhhEmplea();

            rhhEmplea = result.Value.AsODataEnumerable();

            count = result.Count;

            isLoading = false;
        }
        #endregion

        public void Editar()
        {
            Model = selectedModel.FirstOrDefault();
        }
        public async Task SavaButton()
        {

            await rhhEmpleaServices.SaveEmplea(Model);
        }
        public async Task Save(RhhEmplea arg)
        {
            await rhhEmpleaServices.SaveEmplea(Model);
        }
    }
}
