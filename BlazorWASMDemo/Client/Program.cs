global using BlazorWASMDemo.Client;
global using BlazorWASMDemo.Client.Services;
global using BlazorWASMDemo.Client.Services.Interfaces;
global using BlazorWASMDemo.Client.Shared;
global using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });

builder.Services.AddScoped<IAuthService, AuthService>();


await builder.Build().RunAsync();
