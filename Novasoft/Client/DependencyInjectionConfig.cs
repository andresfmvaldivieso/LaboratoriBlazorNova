using Microsoft.Extensions.Configuration;
using Novasoft.Client.Services;
using Novasoft.Client.ViewModels;

namespace Novasoft.Client
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IGenPaiseServices, GenPaiseServices>();
            services.AddScoped<IGenDeptosServices, GenDeptosServices>();
            services.AddScoped<IGenTipideServices, GenTipideServices>();
            services.AddScoped<IGenCiudadesServices, GenCiudadesServices>();
            services.AddScoped<IGthEstCivilServices, GthEstCivilServices>();
            services.AddScoped<IGthGenerosServices, GthGenerosServices>();
            services.AddScoped<ISisAplicacionesServices, SisAplicacionesServices>();
            services.AddScoped<IGenMenuGralServices, GenMenuGralServices>();
            services.AddScoped<IRhhTbTipPagosServices, RhhTbTipPagosServices>();
            services.AddScoped<IGenBancosServices, GenBancosServices>();
            services.AddScoped<IRhhTipconsServices, RhhTipconsServices>();
            services.AddScoped<IRhhTbTipTrabajosServices, RhhTbTipTrabajosServices>();
            services.AddScoped<IRhhTbestlabServices, RhhTbestlabServices>();
            services.AddScoped<IRhhEmpleaServices, RhhEmpleaServices>();
            services.AddScoped<IGenClasif1Services, GenClasif1Services>();
            services.AddScoped<IGenClasif2Services, GenClasif2Services>();
            services.AddScoped<IGenClasif3Services, GenClasif3Services>();
            services.AddScoped<IGenClasif4Services, GenClasif4Services>();
            services.AddScoped<IGenClasif5Services, GenClasif5Services>();
            services.AddScoped<IGenClasif6Services, GenClasif6Services>();
            services.AddScoped<IGenClasif7Services, GenClasif7Services>();
            services.AddScoped<IGenCompaniumsServices, GenCompaniumsServices>();
            services.AddScoped<IGenSucursalesServices, GenSucursalesServices>();
            services.AddScoped<IGenCcostosServices, GenCcostosServices>();
            services.AddScoped<IRhhTbCtaGaServices, RhhTbCtaGaServices>();
            services.AddScoped<IRhhCentroTrabServices, RhhCentroTrabServices>();
            services.AddScoped<IRhhSucursalSsServices, RhhSucursalSsServices>();
            services.AddScoped<IGthAreaServices, GthAreaServices>();
            services.AddScoped<IRhhCargoServices, RhhCargoServices>();
            services.AddScoped <IRhhTbModLiqServices, RhhTbModLiqServices>();
            services.AddScoped <IRhhTbclasalServices, RhhTbclasalServices>();
            services.AddScoped <IRhhTbfondoServices, RhhTbfondoServices>();
            services.AddScoped <IRhhTbmedidaDian2280Services, RhhTbmedidaDian2280Services>();
            services.AddScoped <IRhhTbTipCotizaServices, RhhTbTipCotizaServices>();
            services.AddScoped <IRhhTbSubTipCotizaServices, RhhTbSubTipCotizaServices>();
            services.AddScoped<IWebPaginasmaeServices, WebPaginasmaeServices>();
            services.AddScoped<IWebMaestrosgenServices, WebMaestrosgenServices>();
            services.AddScoped<IUserLoginServices, UserLoginServices>();
            services.AddScoped<IDocumentosViewModel, DocumentosViewModel>();
            services.AddScoped<IWebGridmaestroServices, WebGridmaestroServices>();
            return services;
        }
    }
}
