using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Novasoft.Client;
using Novasoft.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Novasoft.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Novasoft.ServerAPI"));
builder.Services.AddScoped<IGenPaiseServices, GenPaiseServices>();
builder.Services.AddScoped<IGenDeptosServices, GenDeptosServices>();
builder.Services.AddScoped<IGenTipideServices, GenTipideServices>();
builder.Services.AddScoped<IGenCiudadesServices, GenCiudadesServices>();
builder.Services.AddScoped<IGthEstCivilServices, GthEstCivilServices>();
builder.Services.AddScoped<IGthGenerosServices, GthGenerosServices>();
builder.Services.AddApiAuthorization();

await builder.Build().RunAsync();
