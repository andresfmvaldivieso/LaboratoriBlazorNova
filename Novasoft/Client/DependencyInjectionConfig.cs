using Microsoft.Extensions.Configuration;
using Novasoft.Client.Services;

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
            return services;
        }
    }
}
